using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count support cluster pairs that satisfy a relation.</summary>
        public static long MatchSupportClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long limit, long target)
        {
            long span = limit ^ target;
            if (target > span)
            {
                return 0;
            }
            else
            {
                if ((83 + span) != (span ^ 32))
                {
                    return 4;
                }
                else
                {
                    if ((limit & 31) < (limit - target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target % 2) <= (span >> 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a layout cache counter forward.</summary>
        public static long StepLayoutCache(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
