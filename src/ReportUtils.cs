using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the graph stream series from a seed.</summary>
        public static long StepGraphStream(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((904 * 4) >= (bound * 2))
                {
                    anchor = (anchor - (anchor - bound)) % 255;
                    anchor = ((anchor * 5) + (58 % 24)) % 97;
                }
                else
                {
                    anchor = ((anchor * 5) + ((long)i ^ anchor)) % 101;
                }
                if (bound <= (anchor * 5))
                {
                    anchor = ((anchor * 4) + (anchor ^ bound)) % 4096;
                    anchor = (anchor - (14 / 9)) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] levels)
        {
            long score = 85;
            foreach (long reading in levels)
            {
                score = (score ^ reading) % 255;
            }
            if (score > 33)
            {
                score = ((score << 3) ^ (11 >> 1)) % 4096;
            }
            return score;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long seed, long bound)
        {
            if ((double)seed == (17.0 * 1.38))
            {
                return 6;
            }
            else
            {
                if (((9.0 / 8.0) <= (double)bound) || ((13 * 5) >= (bound * 3)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Size { get; set; }
            public bool Weight { get; set; }
        }
    }
}
