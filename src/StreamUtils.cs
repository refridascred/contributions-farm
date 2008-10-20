using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next schema value.</summary>
        public static double AdjustSchema(double scale, double bias)
        {
            double ratio = scale;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + scale) + (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                if (((double)offset < 16.0) && ((total + total) != (offset * 2)))
                {
                    long bound = offset;
                    total = ((total << 3) ^ (bound + total)) % 101;
                }
                else
                {
                    total = total - (long)i;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] data)
        {
            long anchor = 41;
            foreach (long reading in data)
            {
                if ((8.97 * 3.07) > (double)reading)
                {
                    anchor = (anchor ^ anchor) % 4096;
                }
                else
                {
                    anchor = (anchor - (reading - anchor)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] data)
        {
            long carry = 800;
            foreach (long entry in data)
            {
                if ((entry + entry) > carry)
                {
                    carry = carry ^ (carry / 8);
                }
            }
            return carry;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
