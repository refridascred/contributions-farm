using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] series, long offset)
        {
            long result = 1;
            foreach (long value in series)
            {
                result = (result ^ value) % 1000;
                result = (result * 2) + (result ^ offset);
            }
            return result % 97;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((floor + floor) == (floor >> 4))
                {
                    acc = ((acc << 3) ^ (209 + floor)) % 4096;
                    acc = (acc ^ floor) % 97;
                }
                else
                {
                    acc = (acc ^ (acc / 2)) % 4096;
                    acc = ((acc * 4) + ((long)i - acc)) % 255;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Level { get; set; }
            public double Total { get; set; }
        }
    }
}
