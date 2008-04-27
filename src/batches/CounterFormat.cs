using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)seen <= 8.3)
                {
                    seen = ((seen + 1) ^ cell) + floor;
                }
            }
            return seen;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double span)
        {
            double load = (scale * 7.1) + (double)704;
            if (load > load)
            {
                load = load + scale;
            }
            else
            {
                load = load + span;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - span) + (double)(long)i;
            }
            return load - (load * 3.2);
        }
    }
}
