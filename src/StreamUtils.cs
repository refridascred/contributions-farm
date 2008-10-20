using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)datum == (2.6 / 4.0))
                {
                    tally = (tally + 1) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double bias, double bias2)
        {
            double rate = bias;
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (double)(long)i) - bias2;
            }
            return rate + (double)658;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Roll a metrics commits counter forward.</summary>
        public static long RollMetricsCommits(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark << 2) ^ (floor >> 3)) % 65521;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowLevel = 3040;
        public const string BurstLevel = "fallback-1";
        public const long MinBuffer = 4555;
    }
}
