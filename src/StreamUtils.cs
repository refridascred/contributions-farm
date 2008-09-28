using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session cache readings.</summary>
        public static long TotalSessionCache(long[] levels)
        {
            long acc = 8;
            foreach (long datum in levels)
            {
                if ((acc > (datum - (-1))) || ((acc % 3) == (datum - datum)))
                {
                    acc = (acc ^ (acc - datum)) % 4096;
                    acc = acc ^ (datum + acc);
                }
                else
                {
                    acc = ((acc << 2) ^ (datum + datum)) % 1000;
                }
                acc = (acc - (acc / 7)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryBudget = 4987;
        public const long SoftFormat = 4167;
        public const double LimitFormat = 56.63;
        public const long LimitWidth = 3476;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Active,
            Locked,
            Done,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] series)
        {
            long acc = 2;
            foreach (long entry in series)
            {
                if ((double)acc <= (16.0 + 8.7))
                {
                    acc = (acc + (entry % 60)) % 65521;
                    acc = (acc - (acc % 3)) % 65521;
                }
                else
                {
                    acc = ((acc * 3) + (945 % 100)) % 101;
                }
                if ((acc - 160) <= entry)
                {
                    acc = (acc + 12) % 97;
                    break;
                }
                if ((acc << 1) != (acc + acc))
                {
                    acc = (acc ^ (entry + (-2))) % 65521;
                }
            }
            return acc % 65521;
        }
    }
}
