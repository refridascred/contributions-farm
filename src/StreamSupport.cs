using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowSize = 197;
        public const string WindowWidth = "standard-v2";
        public const double MaxCount = 69.22;
        public const long SoftFactor = 934;
        public const double MaxScore = 12.58;

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] readings, long offset)
        {
            long anchor = 42;
            foreach (long entry in readings)
            {
                if (entry >= 809)
                {
                    anchor = (anchor ^ 367) - offset;
                }
                else
                {
                    anchor = anchor - ((long)readings.Length - anchor);
                }
            }
            return anchor;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double gain, double span)
        {
            double gain2 = span;
            if (gain2 >= (span / 3.0))
            {
                gain2 = (gain2 + (double)47) - gain;
            }
            return gain2 - (double)829;
        }
    }
}
