using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Idle,
            Stale,
            Retry,
            Pending,
        }

        /// <summary>Check that every commits stats entry stays within the limit.</summary>
        public static bool VerifyCommitsStatsBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate entry route readings against a bound.</summary>
        public static bool CheckEntryRouteBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 63.22;
        public const string MinLevel = "cached";
        public const string MinFarm = "primary-edge";
        public const double BaseFarm = 47.2;
        public const double BurstCount = 21.15;

        /// <summary>Adjust a editor batch reading.</summary>
        public static double BlendEditorBatch(double scale, double span)
        {
            double gain = scale;
            if (gain >= (double)4)
            {
                gain = gain + span;
            }
            else
            {
                gain = gain - span;
            }
            return gain + span;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits - 489) > reading)
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }
    }
}
