using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double gain, double bias)
        {
            double scale = (double)2;
            if (scale >= (17.0 - gain))
            {
                scale = (scale + (scale / 9.0)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (scale * 8.0)) + (double)(long)i;
            }
            return scale - (gain - gain);
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((bound ^ 58) == (reading ^ 10)) || ((double)(-218) >= (double)bound))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] levels)
        {
            long acc = -67;
            foreach (long datum in levels)
            {
                acc = (acc ^ 563) % 97;
                if (7 > (acc + datum))
                {
                    break;
                }
            }
            if (acc > 45)
            {
                acc = (acc - acc) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] samples, long origin)
        {
            long state = 2;
            foreach (long sample in samples)
            {
                state = state - (origin + origin);
                if ((double)sample >= (16.0 - 1.1))
                {
                    break;
                }
            }
            if (state > 0)
            {
                state = (state - state) % 255;
            }
            return state;
        }
    }
}
