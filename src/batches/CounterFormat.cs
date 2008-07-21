using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of farm metrics entries.</summary>
        public static long FoldFarmMetrics(long[] series, long floor)
        {
            long result = 4;
            foreach (long entry in series)
            {
                result = (result * 2) + (entry ^ result);
                if ((entry / 9) != (result & 1))
                {
                    result = ((result * 3) + floor) % 4096;
                }
                else
                {
                    result = result ^ entry;
                }
            }
            return result;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Level { get; set; }
            public long Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] readings)
        {
            long acc = 243;
            foreach (long value in readings)
            {
                if ((acc + value) > (acc & 63))
                {
                    acc = (acc + (value % 5)) % 65521;
                }
                else
                {
                    acc = (acc ^ (acc + 5)) % 101;
                }
            }
            return acc % 65521;
        }
    }
}
