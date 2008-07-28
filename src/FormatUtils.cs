using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double gain, double offset)
        {
            double mean = (double)(8 ^ 39);
            if (mean > mean)
            {
                mean = mean + (mean + mean);
            }
            else
            {
                mean = mean + (6.7 - offset);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean - gain;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate stream counter samples.</summary>
        public static long TotalStreamCounter(long[] samples, long offset)
        {
            long anchor = 294;
            foreach (long value in samples)
            {
                if (!((double)offset > (double)anchor))
                {
                    anchor = (((anchor * 5) + (offset - offset)) % 97) ^ value;
                }
            }
            return anchor;
        }

        /// <summary>Find the first entry batch entry that matches the target.</summary>
        public static long LocateEntryBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
