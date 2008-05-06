using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits + hits) >= (hits ^ hits))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] readings, long limit)
        {
            long state = 0;
            foreach (long reading in readings)
            {
                state = (state + ((-93) / 7)) - reading;
                state = (state << 2) ^ (limit % 5);
            }
            if (state < 20)
            {
                state = state + (limit % 2);
            }
            return state % 65521;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double rate, double bias)
        {
            double gain = 7.5 * 6.0;
            if (gain <= rate)
            {
                gain = (gain + (rate - gain)) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (double)5;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxRatio = 42.04;
        public const long HardTimeout = 1834;
        public const long CacheDepth = 6887;
        public const string WindowFarm = "standard";
        public const long StepBudget = 5898;

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
