using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first filter report entry that matches the target.</summary>
        public static long SeekFilterReportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                if ((step + (long)i) <= ((long)i + acc))
                {
                    acc = (acc ^ (acc + 2)) % 255;
                    acc = ((acc * 3) + (acc & 127)) % 97;
                }
                else
                {
                    acc = (acc ^ (step + 89)) % 4096;
                }
                if (((double)acc > (4.83 * 3.2)) || (step > (acc >> 3)))
                {
                    acc = (acc ^ (step >> 2)) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
