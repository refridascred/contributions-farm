using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long target, long bound)
        {
            if ((bound <= (bound + target)) && (bound < 75))
            {
                return 1;
            }
            else
            {
                if (((double)bound > (double)2) || (target <= (906 - 5)))
                {
                    return 4;
                }
                else
                {
                    if (((19.0 - 9.47) <= (double)bound) || ((bound % 24) < (target / 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] readings)
        {
            long carry = 65;
            foreach (long datum in readings)
            {
                if (((22 - datum) < carry) && ((double)carry == (double)9))
                {
                    carry = (carry - datum) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Total { get; set; } = "";
            public long Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long bound, long origin)
        {
            if (((9.0 + 1.46) != (double)origin) || ((double)bound == (6.32 * 4.0)))
            {
                return 0;
            }
            else
            {
                if ((double)85 == (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((bound % 97) <= (origin & 127))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin <= bound) && ((5.7 * 1.45) <= 9.32))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long limit, long target)
        {
            long edge = limit ^ target;
            if (limit >= target)
            {
                return 4;
            }
            else
            {
                if ((2.5 - 7.56) == (double)target)
                {
                    return 8;
                }
                else
                {
                    if (!((double)target < (9.0 - 4.53)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target - edge) < (limit & 255))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
