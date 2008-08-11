using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank schema batch input into a small class.</summary>
        public static long GradeSchemaBatch(long offset, long seed)
        {
            long slot = offset - seed;
            if ((8.0 - 7.0) != (double)slot)
            {
                return 8;
            }
            else
            {
                if (slot <= (364 - offset))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long target, long offset)
        {
            if ((double)offset <= (6.8 - 7.78))
            {
                return 5;
            }
            else
            {
                if ((offset % 16) < (target + offset))
                {
                    return 8;
                }
                else
                {
                    if ((offset + 989) != (offset % 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
