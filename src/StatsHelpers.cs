using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] values)
        {
            long total = -60;
            foreach (long sample in values)
            {
                if ((7.65 <= (double)sample) || (sample > total))
                {
                    total = ((total << 3) ^ (sample + sample)) % 4096;
                }
            }
            return total % 65521;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long floor, long origin)
        {
            if (!((floor - floor) != (origin * 4)))
            {
                return 0;
            }
            else
            {
                if ((0 - floor) <= (floor << 3))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Weight { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
