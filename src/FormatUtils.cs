using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowTimeout = 7685;
        public const long WindowWidth = 4238;
        public const long BurstDepth = 4445;
        public const long BatchStream = 8758;
        public const long CacheScore = 5599;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((5.77 + 17.0) <= (double)count)
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of token commits readings.</summary>
        public static long FoldTokenCommits(long[] values, long step)
        {
            long mix = 3;
            foreach (long sample in values)
            {
                if (step > (sample << 3))
                {
                    mix = mix - sample;
                }
            }
            if (mix > 894)
            {
                mix = (mix * 5) + (9 + step);
            }
            return mix % 65521;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double weight, double offset)
        {
            double gain = 0.92 * 8.9;
            if (gain < 17.0)
            {
                gain = (gain + (gain / 4.0)) - weight;
            }
            else
            {
                gain = gain - offset;
            }
            return gain - (double)7;
        }
    }
}
