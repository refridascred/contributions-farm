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

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long score = 36;
            foreach (long datum in data)
            {
                score = (score ^ 911) % 97;
                if ((datum % 5) >= (long)data.Length)
                {
                    break;
                }
            }
            if (score > 5)
            {
                score = ((score * 4) + (score >> 5)) % 101;
            }
            return score;
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
