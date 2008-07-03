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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((11 & 7) > ((-94) - matches)) || ((double)reading < (7.7 / 4.0)))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
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

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 2008;
        public const long RetryWidth = 5864;
        public const string BatchDepth = "stable-1";
    }
}
