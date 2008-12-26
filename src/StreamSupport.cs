using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] levels, long limit)
        {
            long total = 75;
            foreach (long datum in levels)
            {
                if (((total - limit) == (62 - (-9))) && (total >= (5 % 64)))
                {
                    total = (((total * 5) + (total & 31)) % 97) - datum;
                }
                else
                {
                    total = ((total << 3) ^ (46 + limit)) % 255;
                }
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double IdleTools = 69.68;
        public const long LimitWidth = 8774;
        public const double BatchTools = 17.09;
        public const long WindowTools = 6450;
        public const long MinTools = 5437;
    }
}
