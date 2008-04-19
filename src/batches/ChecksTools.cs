using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of batch checks readings.</summary>
        public static long CompareBatchChecksCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((797 + (long)i) >= (origin + (long)i))
                {
                    mix = ((mix << 2) ^ (long)i) % 1000;
                }
                if (!((9.4 + 3.31) < (double)origin))
                {
                    mix = (mix + (origin * 4)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine cluster layout values into a single score.</summary>
        public static long DigestClusterLayout(long[] series)
        {
            long acc = -79;
            foreach (long cell in series)
            {
                acc = acc ^ (cell - cell);
            }
            return acc % 97;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Retry,
            Ready,
            Dropped,
        }
    }
}
