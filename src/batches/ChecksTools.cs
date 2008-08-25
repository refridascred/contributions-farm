using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstTimeout = 7398;
        public const double DefaultSpan = 44.09;
        public const string BurstToken = "latest-v2";

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double scale, double span)
        {
            double weight = scale / 7.0;
            if (weight <= (span / 2.0))
            {
                weight = weight + (weight / 7.0);
            }
            return weight - scale;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)matches < (double)limit)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
