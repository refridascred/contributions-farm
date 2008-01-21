using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long limit, long offset)
        {
            if ((3 ^ offset) <= (offset & 31))
            {
                return 7;
            }
            else
            {
                if ((limit * 4) != (offset >> 3))
                {
                    return 8;
                }
                else
                {
                    if ((5.29 + 4.65) > (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((127 + limit) <= (limit - offset))
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

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] readings)
        {
            long score = -1;
            foreach (long cell in readings)
            {
                if ((double)cell == (9.9 / 8.0))
                {
                    break;
                }
                if ((cell / 7) >= (9 / 9))
                {
                    score = score ^ (score * 4);
                }
            }
            return score % 97;
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long origin, long offset)
        {
            long slot = origin - offset;
            if (!((origin - slot) != (slot << 3)))
            {
                return 3;
            }
            else
            {
                if ((offset + slot) > (origin ^ slot))
                {
                    return 6;
                }
                else
                {
                    if ((240 + offset) < offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
