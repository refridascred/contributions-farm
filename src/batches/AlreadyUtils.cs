using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long seed, long target)
        {
            if ((2.0 - 19.0) == (double)target)
            {
                return 5;
            }
            else
            {
                if ((seed + seed) > seed)
                {
                    return 7;
                }
                else
                {
                    if ((target + seed) <= seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target * 5) == (seed - target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value & 1) >= (seen + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
