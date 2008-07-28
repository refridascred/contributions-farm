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

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] series)
        {
            long carry = 17;
            foreach (long item in series)
            {
                if ((carry + item) >= (carry + carry))
                {
                    carry = carry + (carry + (long)series.Length);
                }
                else
                {
                    carry = (carry + (carry / 6)) % 255;
                }
            }
            return carry;
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
