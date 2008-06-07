using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long limit, long limit2)
        {
            long next = limit ^ limit2;
            if (next <= (limit2 << 3))
            {
                return 0;
            }
            else
            {
                if ((limit / 4) < (limit2 - (-18)))
                {
                    return 5;
                }
                else
                {
                    if ((-56) > (limit >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((next ^ limit) < limit2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a tools checks sample.</summary>
        public static long FindToolsChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Active,
            Stale,
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
