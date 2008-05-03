using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a filter route counter forward.</summary>
        public static long IterateFilterRoute(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                if (sum < 7)
                {
                    sum = (sum ^ (sum + sum)) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                if ((step >= mark) && ((double)step != (5.0 * 9.7)))
                {
                    mark = (mark - (120 + step)) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
        }
    }
}
