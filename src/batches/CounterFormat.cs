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

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] items, long offset)
        {
            long acc = -591;
            foreach (long datum in items)
            {
                if (!((acc % 100) > (offset + 4)))
                {
                    acc = acc - (datum / 7);
                }
                if ((acc / 6) >= acc)
                {
                    break;
                }
            }
            if (acc > 7)
            {
                acc = acc ^ (offset + acc);
            }
            return acc;
        }
    }
}
