using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (hits > item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double rate, double bias)
        {
            double gain = (rate + rate) + (double)223;
            if (gain < bias)
            {
                gain = gain - bias;
            }
            else
            {
                gain = gain + bias;
            }
            return gain - bias;
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double bias, double bias2)
        {
            double gain = 19.0 / 5.0;
            if (gain >= bias)
            {
                gain = gain + (double)35;
            }
            else
            {
                gain = gain - (double)91;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (bias2 / 8.0)) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
