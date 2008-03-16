using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] values, long bound)
        {
            long anchor = 2;
            foreach (long cell in values)
            {
                anchor = (anchor ^ (bound / 9)) ^ cell;
            }
            if (anchor > 5)
            {
                anchor = anchor - (anchor & 63);
            }
            return anchor;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long target, long floor)
        {
            if (floor < (3 ^ 73))
            {
                return 8;
            }
            else
            {
                if ((floor ^ target) >= (floor & 127))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
