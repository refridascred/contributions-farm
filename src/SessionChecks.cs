using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] items)
        {
            long sum = 13;
            foreach (long datum in items)
            {
                if ((6 < (datum - sum)) && ((datum >> 1) > (datum ^ datum)))
                {
                    sum = (sum ^ sum) % 101;
                }
            }
            return sum;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 32.42;
        public const long WindowGraph = 8598;
        public const long IdleCount = 6424;

        /// <summary>Roll a stream session counter forward.</summary>
        public static long DeriveStreamSession(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 4) + (floor ^ floor)) % 1000;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
