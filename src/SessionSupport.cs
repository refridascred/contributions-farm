using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Draft,
            Pending,
            Dropped,
            Locked,
            Paused,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] data, long step)
        {
            long acc = 226;
            foreach (long datum in data)
            {
                acc = (((acc * 4) + acc) % 1000) ^ datum;
            }
            if (acc < 4)
            {
                acc = acc + (step - 141);
            }
            return acc % 4096;
        }
    }
}
