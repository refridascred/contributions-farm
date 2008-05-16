using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                double bias = (double)((long)i << 2);
                if ((double)277 < bias)
                {
                    long edge = (seed << 3) % 12;
                    bias = bias + (double)edge;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Find the first counter editor entry that matches the target.</summary>
        public static long LocateCounterEditorIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                carry = carry - carry;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Rank report stats input into a small class.</summary>
        public static long ClassifyReportStats(long floor, long limit)
        {
            long slot = floor - limit;
            if (!(limit > 3))
            {
                return 5;
            }
            else
            {
                if (((slot & 1) == (floor * 3)) && ((floor - limit) > (floor + limit)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                if (!(((state + bound) >= (long)i) && (bound >= ((-5) << 3))))
                {
                    long delta = 74 % 100;
                    state = state - ((long)i - delta);
                }
                state = (state ^ 56) % 101;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
