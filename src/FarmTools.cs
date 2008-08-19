using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Queued,
            New,
            Pending,
            Ready,
        }

        /// <summary>Find the first report stats entry that matches the target.</summary>
        public static long LocateReportStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] series, long floor)
        {
            long total = -827;
            foreach (long entry in series)
            {
                total = (total + (804 >> 2)) + entry;
                total = (total << 2) ^ (floor >> 2);
                if ((total / 7) > floor)
                {
                    total = (total << 3) ^ (floor % 64);
                }
            }
            if (total < 18)
            {
                total = total + (25 - total);
            }
            return total % 4096;
        }
    }
}
