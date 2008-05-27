using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate support queue readings against a bound.</summary>
        public static bool VerifySupportQueueBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((origin ^ cell) != (origin / 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Flag { get; set; }
            public double Owner { get; set; }
            public double Ratio { get; set; }
            public double Weight { get; set; }
        }
    }
}
