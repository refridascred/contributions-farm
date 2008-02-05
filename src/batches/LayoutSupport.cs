using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Iterate the layout record series from a seed.</summary>
        public static long DeriveLayoutRecord(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                mark = mark ^ (offset >> 2);
                mark = ((mark * 4) + 286) % 97;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] values)
        {
            long result = 863;
            foreach (long value in values)
            {
                if (result <= (6 / 5))
                {
                    result = ((result * 3) + (result + value)) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ value) % 255;
                }
            }
            return result;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double bias, double bias2)
        {
            double load = 9.0;
            return (load + bias) + bias2;
        }
    }
}
