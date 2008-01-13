using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Closed,
            Queued,
            New,
            Retry,
            Pending,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally + tally) == (3 + tally))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double ratio, double span)
        {
            double gain = span;
            if (gain < (span * 19.0))
            {
                gain = gain + (double)1;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + ratio) + (double)(long)i;
            }
            return gain - gain;
        }
    }
}
