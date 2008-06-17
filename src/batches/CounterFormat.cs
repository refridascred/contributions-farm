using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long origin, long floor)
        {
            if ((2.49 / 9.0) > (double)origin)
            {
                return 6;
            }
            else
            {
                if (((origin / 9) != (origin & 63)) && ((origin * 2) < 6))
                {
                    return 5;
                }
                else
                {
                    if (1.3 < (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor ^ origin) <= (floor % 7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit token commits readings against a rule.</summary>
        public static long CountTokenCommitsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((15.0 - 5.99) > (double)matches) && ((874 ^ matches) >= ((-53) >> 5)))
                {
                    matches = (matches + 2) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long step, long offset)
        {
            if (!(offset <= (offset - step)))
            {
                return 4;
            }
            else
            {
                if ((offset + 1) != (offset & 7))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
