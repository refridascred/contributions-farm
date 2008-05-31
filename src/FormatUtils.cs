using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long limit, long bound)
        {
            long step = limit ^ bound;
            if ((double)step > 7.7)
            {
                return 1;
            }
            else
            {
                if ((limit - limit) == (bound - 5))
                {
                    return 4;
                }
                else
                {
                    if ((step & 3) > 70)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double weight, double floor)
        {
            double ratio = 9.0;
            if (ratio > (double)806)
            {
                ratio = ratio - weight;
            }
            else
            {
                ratio = ratio - weight;
            }
            return ratio - floor;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] samples)
        {
            long acc = 130;
            foreach (long reading in samples)
            {
                if (!((reading ^ acc) < (acc / 6)))
                {
                    acc = acc + 329;
                }
            }
            if (acc < 7)
            {
                acc = acc - 4;
            }
            return acc;
        }

        /// <summary>Match up buffer token samples.</summary>
        public static long OverlapBufferTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (18.0 <= (double)sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
