using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next batches checks value.</summary>
        public static double BlendBatchesChecks(double ratio, double bias)
        {
            double mean = (double)(932 + 322);
            if (mean >= 5.0)
            {
                mean = (mean + ratio) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean / 5.0)) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Pending,
            New,
            Done,
        }
    }
}
