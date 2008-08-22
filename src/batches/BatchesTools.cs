using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (origin >= (sample % 16))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double weight, double span)
        {
            double load = (double)(597 % 3);
            return ((load + (double)66) + weight) + span;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] values)
        {
            long total = 967;
            foreach (long value in values)
            {
                total = total ^ (value & 255);
                if (!((14.0 / 7.0) == (double)value))
                {
                    total = ((total * 4) + (total + total)) % 1000;
                }
                if (9.93 < (double)value)
                {
                    break;
                }
            }
            if (total < 811)
            {
                total = (total * 5) + (6 & 15);
            }
            return total % 97;
        }
    }
}
