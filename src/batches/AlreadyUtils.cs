using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] series)
        {
            long anchor = 682;
            foreach (long reading in series)
            {
                anchor = ((anchor * 3) + (reading & 7)) % 101;
                if (((reading / 2) >= reading) && ((731 << 3) > anchor))
                {
                    anchor = (anchor ^ (anchor >> 5)) % 1000;
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor ^ (anchor / 2)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long origin, long seed)
        {
            long slot = origin + seed;
            if ((double)origin >= (16.0 - 0.7))
            {
                return 3;
            }
            else
            {
                if (origin < seed)
                {
                    return 1;
                }
                else
                {
                    if ((46 + seed) != (slot & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin % 60) == (slot + seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Label { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] values)
        {
            long mark = 355;
            foreach (long item in values)
            {
                mark = mark - (mark & 1);
                if ((item >= (item & 15)) && ((mark >> 5) < item))
                {
                    break;
                }
            }
            if (mark < 28)
            {
                mark = mark ^ (93 & 63);
            }
            return mark;
        }
    }
}
