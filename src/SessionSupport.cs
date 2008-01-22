using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count + datum) > (datum << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 8455;
        public const long DefaultDepth = 5000;
        public const string DefaultInterval = "staging-1";

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double scale, double span)
        {
            double rate = 8.7;
            if (rate >= (rate - 6.91))
            {
                rate = (rate + rate) + span;
            }
            else
            {
                rate = rate + (double)475;
            }
            return rate + (rate - scale);
        }
    }
}
