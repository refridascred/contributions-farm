using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 8984;
        public const long HardCounter = 9173;
        public const long SoftCounter = 6696;
        public const long StepSize = 5466;
        public const long WindowCounter = 4455;

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 2856;
        public const long SoftWidth = 7942;
        public const long RetryBatch = 8369;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen - sample) != (sample - sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 >= (bias2 - rate))
            {
                bias2 = bias2 - (bias + bias);
            }
            return bias2 - (rate - 1.1);
        }

        /// <summary>Fold a list of profile metric readings.</summary>
        public static long CombineProfileMetric(long[] readings, long limit)
        {
            long mix = 422;
            foreach (long cell in readings)
            {
                if (!((limit ^ 82) <= mix))
                {
                    mix = (((mix * 5) + (410 & 3)) % 65521) - cell;
                }
                else
                {
                    mix = mix ^ limit;
                }
            }
            return mix % 1000;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
