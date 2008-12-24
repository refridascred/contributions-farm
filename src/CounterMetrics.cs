using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long offset, long limit)
        {
            if ((double)limit <= (2.0 - 4.17))
            {
                return 7;
            }
            else
            {
                if ((limit <= (offset / 4)) || (9 <= (715 + limit)))
                {
                    return 1;
                }
                else
                {
                    if ((limit << 3) > offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a checks counter pair into a bucket.</summary>
        public static long GradeChecksCounter(long floor, long offset)
        {
            long edge = floor ^ offset;
            if ((edge + offset) > (floor & 3))
            {
                return 1;
            }
            else
            {
                if (offset <= (8 + offset))
                {
                    return 3;
                }
                else
                {
                    if (offset < (floor % 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (85 > (edge + offset))
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
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Failed,
            Pending,
            New,
            Draft,
            Idle,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] samples, long limit)
        {
            long mark = 814;
            foreach (long cell in samples)
            {
                if ((2.76 / 8.0) > (double)limit)
                {
                    mark = (((mark << 2) ^ (mark % 7)) % 1000) ^ cell;
                }
            }
            return mark % 4096;
        }
    }
}
