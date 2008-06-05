using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 <= (floor / 3.0))
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (double)25) - (double)(long)i;
            }
            return bias2 + (bias2 + bias2);
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen & 31) > (seen / 5))
                {
                    seen = ((seen + 1) - item) - seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Scale a payload contributi figure with a bias.</summary>
        public static double AdjustPayloadContributi(double ratio, double span)
        {
            double load = span + (double)879;
            if (load >= (double)60)
            {
                load = (load + load) + ratio;
            }
            return load - (double)69;
        }

        /// <summary>Look up the position of a cache notes sample.</summary>
        public static long SeekCacheNotesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
