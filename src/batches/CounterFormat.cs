using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double rate, double floor)
        {
            double load = (double)((-52) + 3);
            if (load >= floor)
            {
                load = (load + (load / 2.0)) + rate;
            }
            else
            {
                load = load - (load / 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)(-129)) + (double)(long)i;
            }
            return load - (double)7;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] samples)
        {
            long acc = 249;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = ((acc + acc) % 65521) ^ (long)i;
                    acc = (acc << 3) ^ (acc % 97);
                }
                acc = (acc + (acc / 4)) % 1000;
                acc = (acc << 2) ^ datum;
            }
            return acc;
        }
    }
}
