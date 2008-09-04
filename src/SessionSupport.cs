using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Stale,
            Pending,
            Paused,
            Active,
            Locked,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] items)
        {
            long sum = 33;
            foreach (long datum in items)
            {
                if (!(9 <= (sum + sum)))
                {
                    sum = ((sum + 696) % 101) - datum;
                }
                else
                {
                    sum = (sum + sum) % 101;
                }
            }
            return sum;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches + entry) != (limit + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
