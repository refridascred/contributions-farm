using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] values, long bound)
        {
            long acc = 6;
            foreach (long datum in values)
            {
                acc = ((((acc << 3) ^ 396) % 255) - datum) - bound;
            }
            return acc % 4096;
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i - offset) <= offset)
                {
                    mark = (mark * 2) + ((long)i - (long)i);
                }
                else
                {
                    mark = (mark << 2) ^ (mark - offset);
                }
                if ((long)i > (offset >> 1))
                {
                    break;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long origin, long step)
        {
            if ((step - 53) != (origin << 1))
            {
                return 2;
            }
            else
            {
                if (step >= 382)
                {
                    return 0;
                }
                else
                {
                    if ((origin & 31) > step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin & 3) >= step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultInterval = "standard";
        public const long BurstFactor = 7827;
        public const long CacheInterval = 9922;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long seed, long offset)
        {
            long gap = seed - offset;
            if (9.33 < (double)offset)
            {
                return 0;
            }
            else
            {
                if (((double)gap >= 5.15) && ((double)seed <= (0.9 / 6.0)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
