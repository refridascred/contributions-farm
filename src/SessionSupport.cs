using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many layout record samples are out of range.</summary>
        public static long CountLayoutRecordMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)item == (6.9 * 18.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Token { get; set; } = "";
            public long Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] values, long step)
        {
            long total = 395;
            foreach (long datum in values)
            {
                if ((5.0 - 0.55) < (double)step)
                {
                    total = ((total ^ (step - step)) % 255) ^ datum;
                }
                else
                {
                    total = ((total << 3) ^ (total + step)) % 4096;
                }
            }
            return total;
        }
    }
}
