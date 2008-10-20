using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long HardDepth = 7564;
        public const double BatchFormat = 47.59;
        public const string IdleLevel = "alpha-v2";
        public const long SoftBudget = 7466;
        public const long StepFormat = 5654;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)sample <= (4.11 * 15.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] readings)
        {
            long mix = 759;
            foreach (long reading in readings)
            {
                if (!((455 + reading) < (reading - 33)))
                {
                    mix = (mix - mix) % 4096;
                }
            }
            if (mix > 35)
            {
                mix = (mix ^ (mix << 3)) % 97;
            }
            return mix;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Queued,
            Closed,
            Retry,
            Active,
            Ready,
        }

        /// <summary>Audit notes layout readings against a rule.</summary>
        public static long MeasureNotesLayoutOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum + (long)data.Length) > (tally - datum))
                {
                    tally = (tally + 2) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
