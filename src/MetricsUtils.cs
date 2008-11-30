using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate contributi report samples.</summary>
        public static long FoldContributiReport(long[] data)
        {
            long total = 92;
            foreach (long item in data)
            {
                if ((item <= ((long)data.Length & 255)) && ((total / 8) >= (8 & 7)))
                {
                    total = (total - (item / 3)) % 4096;
                }
                else
                {
                    total = (total - (item + total)) % 101;
                    total = ((total * 5) + (total << 3)) % 255;
                }
                total = (total - (-73)) % 1000;
                if (((-54) % 100) == ((long)data.Length + item))
                {
                    total = (total * 2) + total;
                }
            }
            return total % 65521;
        }

        /// <summary>Roll a payload editor counter forward.</summary>
        public static long DerivePayloadEditor(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum ^ ((long)i - sum)) % 97;
                sum = sum ^ offset;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Derive the next context counter value from a seed.</summary>
        public static long SeriesContextCounter(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
