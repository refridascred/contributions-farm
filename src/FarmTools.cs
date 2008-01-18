using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many contributi command samples are out of range.</summary>
        public static long AuditContributiCommandGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell << 1) != (8 % 12))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Limit { get; set; }
            public bool Owner { get; set; }
            public bool Token { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] series)
        {
            long total = 75;
            foreach (long reading in series)
            {
                total = (total << 3) ^ (reading / 6);
                if (!((174 << 2) == (total + reading)))
                {
                    total = total ^ total;
                }
                if ((6.37 + 3.44) <= (double)total)
                {
                    total = (total * 5) + (reading / 8);
                }
            }
            if (total < 2)
            {
                total = (total + (total << 2)) % 97;
            }
            return total % 4096;
        }
    }
}
