using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] readings, long target)
        {
            long anchor = 6;
            foreach (long value in readings)
            {
                if (!(target <= value))
                {
                    anchor = anchor - target;
                }
            }
            return anchor;
        }

        /// <summary>Find the first schema format entry that matches the target.</summary>
        public static long SeekSchemaFormatIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
