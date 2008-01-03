using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine record counter values into a single score.</summary>
        public static long WeighRecordCounter(long[] series, long origin)
        {
            long score = 907;
            foreach (long entry in series)
            {
                score = (score - score) + entry;
            }
            if (score < 619)
            {
                score = (score + origin) % 255;
            }
            return score % 97;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((((entry * 2) != (offset + 36)) && ((entry << 2) > matches)) && ((matches + offset) >= (offset % 97)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Count { get; set; } = "";
            public bool Ratio { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double bias, double span)
        {
            double scale = (5.7 * 9.4) - bias;
            if (scale <= span)
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale + span;
            }
            return scale + (double)94;
        }
    }
}
