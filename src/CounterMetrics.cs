using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double scale, double span)
        {
            double mean = 3.0;
            if (mean < 9.35)
            {
                mean = ((mean - (double)17) - scale) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + 9.7;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((7 / 3) > limit)
                {
                    tally = (tally + 3) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] samples, long limit)
        {
            long result = 4;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = (result + result) ^ (long)i;
                    result = (result << 2) ^ (limit - 5);
                }
                if ((result + cell) >= (limit - cell))
                {
                    result = ((result * 4) + (result >> 4)) % 97;
                }
            }
            return result;
        }

        /// <summary>Rank editor cluster input into a small class.</summary>
        public static long RankEditorCluster(long limit, long step)
        {
            if (step >= (step + step))
            {
                return 2;
            }
            else
            {
                if ((limit * 5) >= (limit ^ 2))
                {
                    return 7;
                }
                else
                {
                    if (((step * 2) >= (limit % 16)) || ((limit >> 4) < (limit >> 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
