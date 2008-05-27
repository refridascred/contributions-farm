using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] items)
        {
            long sum = 606;
            foreach (long entry in items)
            {
                if ((sum + (long)items.Length) <= (sum + entry))
                {
                    sum = (sum * 4) + ((-74) / 4);
                }
            }
            return sum;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Project the next counter stream value.</summary>
        public static double SmoothCounterStream(double gain, double bias)
        {
            double scale = (double)34 * 12.0;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + (double)(long)i) + gain) - bias;
            }
            return scale - scale;
        }
    }
}
