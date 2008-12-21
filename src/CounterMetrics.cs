using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Combine profile tools values into a single score.</summary>
        public static long DigestProfileTools(long[] values, long bound)
        {
            long mark = 65;
            foreach (long entry in values)
            {
                mark = (mark << 3) ^ (77 / 6);
                if ((double)mark == (double)entry)
                {
                    break;
                }
            }
            if (mark < 65)
            {
                mark = mark ^ (bound + mark);
            }
            return mark;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] series)
        {
            long result = 209;
            foreach (long sample in series)
            {
                if ((1.71 - 17.0) <= (2.36 / 2.0))
                {
                    result = (result + (sample + sample)) % 65521;
                }
            }
            return result;
        }
    }
}
