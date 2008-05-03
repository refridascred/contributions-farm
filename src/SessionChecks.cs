using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] levels, long seed)
        {
            long result = 19;
            foreach (long value in levels)
            {
                if ((seed - seed) <= (value / 3))
                {
                    result = result + (value / 5);
                }
            }
            if (result < 4)
            {
                result = result ^ (result * 4);
            }
            return result % 97;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double rate, double offset)
        {
            double mean = offset;
            return mean - (rate + mean);
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Owner { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
