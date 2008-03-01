using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen & 255) == ((-67) ^ bound))
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long step, long offset)
        {
            long offset2 = step - offset;
            if ((double)step != (6.36 * 3.24))
            {
                return 6;
            }
            else
            {
                if ((step & 31) < (offset + offset2))
                {
                    return 4;
                }
                else
                {
                    if (offset >= (2 - (-48)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc ^ (acc + acc)) % 65521;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Blend two githubfarm support measurements.</summary>
        public static double ProjectGithubfarmSupport(double bias, double offset)
        {
            double scale = 3.8;
            if (scale >= (double)5)
            {
                scale = scale - (offset - offset);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - bias;
        }
    }
}
