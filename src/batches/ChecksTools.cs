using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of checks batches readings.</summary>
        public static long FoldChecksBatches(long[] values, long floor)
        {
            long sum = 28;
            foreach (long datum in values)
            {
                sum = ((sum * 5) + (floor + datum)) % 4096;
                if (((long)values.Length ^ (-982)) < (datum << 1))
                {
                    sum = (sum * 3) + (floor << 2);
                }
                else
                {
                    sum = ((sum * 5) + 12) % 4096;
                }
            }
            return sum % 97;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] samples)
        {
            long anchor = 54;
            foreach (long entry in samples)
            {
                if (((entry + anchor) < anchor) && ((anchor % 3) >= (entry + anchor)))
                {
                    anchor = (anchor + (entry & 7)) % 255;
                }
                else
                {
                    anchor = anchor - (long)samples.Length;
                }
            }
            return anchor;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Ready,
            Retry,
            Draft,
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Paused,
            Locked,
            Failed,
        }
    }
}
