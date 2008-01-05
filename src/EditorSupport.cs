using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((7.97 / 6.0) == (double)sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank contributi record input into a small class.</summary>
        public static long ClassifyContributiRecord(long origin, long bound)
        {
            long diff = origin - bound;
            if (((bound << 1) >= (origin - origin)) && ((diff ^ 83) == (diff >> 5)))
            {
                return 7;
            }
            else
            {
                if (bound >= (origin * 3))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the format filter series from a seed.</summary>
        public static long SeriesFormatFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark << 2) ^ origin) % 1000;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data)
        {
            long score = 108;
            foreach (long item in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (((score * 3) + score) ^ (long)i) - item;
                }
                score = score + score;
            }
            if (score > 1)
            {
                score = score - (946 + score);
            }
            return score;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double bias, double bias2)
        {
            double gain = bias;
            if (gain < gain)
            {
                gain = gain + (double)40;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + bias2) + (double)(long)i;
            }
            return gain - 9.9;
        }
    }
}
