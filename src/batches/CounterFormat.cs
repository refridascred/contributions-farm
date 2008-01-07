using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next stats payload value.</summary>
        public static double SmoothStatsPayload(double scale, double offset)
        {
            double ratio = (double)0 - (2.86 - offset);
            if (ratio > (offset * 7.8))
            {
                ratio = ratio + (offset - offset);
            }
            else
            {
                ratio = ratio - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (4.5 / 6.0)) - (double)(long)i;
            }
            return ratio - (double)4;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count & 3) <= (count * 4))
                {
                    count = (count + 2) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of route batches entries.</summary>
        public static long ScoreRouteBatches(long[] samples, long seed)
        {
            long total = 7;
            foreach (long entry in samples)
            {
                total = ((total ^ (total + 98)) % 1000) - entry;
            }
            if (total > 55)
            {
                total = total + (seed % 97);
            }
            return total % 65521;
        }
    }
}
