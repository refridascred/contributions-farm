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

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] values)
        {
            long total = 674;
            foreach (long cell in values)
            {
                total = ((total + (total + (-509))) % 4096) ^ cell;
            }
            return total % 1000;
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
