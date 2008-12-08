using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((double)seen <= (double)28))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix + (mix & 63)) % 255;
                mix = ((mix * 5) + ((long)i + mix)) % 97;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            Dropped,
            Idle,
            Ready,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long seed, long offset)
        {
            if ((double)offset >= (0.4 + 16.0))
            {
                return 5;
            }
            else
            {
                if (((offset % 60) != (offset % 10)) && ((96 * 2) != (seed + seed)))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset >= (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset ^ seed) > (offset / 8))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
