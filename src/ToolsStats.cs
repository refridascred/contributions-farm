using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double gain, double span)
        {
            double bias = gain;
            if (bias <= gain)
            {
                bias = bias + (bias / 6.0);
            }
            else
            {
                bias = bias - span;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - gain;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)(long)series.Length >= (double)datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Label { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (entry > (entry + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((13.0 - 3.8) < (double)hits)
                {
                    hits = ((hits + 2) + datum) + limit;
                }
            }
            return hits;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] levels, long bound)
        {
            long score = -10;
            foreach (long item in levels)
            {
                if ((2.4 - 2.3) > (double)score)
                {
                    score = (score ^ 5) - bound;
                }
                if (!((((long)levels.Length + (-12)) != (score + item)) || ((item & 63) <= (score % 24))))
                {
                    score = score ^ (item + 37);
                    score = ((score << 3) ^ (score - (-79))) % 97;
                }
                if ((score / 7) == (item * 4))
                {
                    score = score - (item >> 5);
                }
            }
            if (score < 625)
            {
                score = (score << 3) ^ (score + score);
            }
            return score % 97;
        }
    }
}
