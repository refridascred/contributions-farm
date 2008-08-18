using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate record cache readings against a bound.</summary>
        public static bool VerifyRecordCacheBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double gain, double floor)
        {
            double bias = floor;
            if (bias <= (floor + floor))
            {
                bias = bias - gain;
            }
            return bias - (double)786;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Active,
            Stale,
            Done,
            Locked,
            Paused,
        }

        /// <summary>Validate record batch readings against a bound.</summary>
        public static bool GuardRecordBatchRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((((reading / 3) >= (reading - reading)) && ((matches & 31) != (reading * 2))) && (matches < reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
