using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the report stats series from a seed.</summary>
        public static long IterateReportStats(long bound)
        {
            long total = bound;
            for (int i = 0; i < 6; i++)
            {
                if (53 < (total + bound))
                {
                    total = (total * 3) + ((long)i * 2);
                    total = (total ^ (total % 10)) % 97;
                }
                if ((total - total) > bound)
                {
                    total = ((total << 3) ^ (long)i) % 97;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = (total - (bound + 517)) + (long)i2;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = ((carry << 3) ^ (target ^ 7)) % 4096;
                    carry = (carry - (target + (long)i2)) % 1000;
                }
                if (target < (target >> 3))
                {
                    carry = ((carry * 2) + ((long)i / 2)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Stale,
            Locked,
            Queued,
            Pending,
        }
    }
}
