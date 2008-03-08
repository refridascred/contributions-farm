using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            New,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double rate, double bias)
        {
            double bias2 = (rate / 5.0) * 15.0;
            return (bias2 - 9.82) + bias;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor * 5) + 8;
                anchor = ((anchor * 4) + anchor) % 65521;
                if (((long)i + (-148)) > (anchor / 3))
                {
                    anchor = (anchor << 3) ^ 15;
                    anchor = (anchor ^ (offset << 2)) % 101;
                }
                else
                {
                    anchor = (anchor * 5) + (872 << 1);
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Look up the position of a checks githubfarm sample.</summary>
        public static long FindChecksGithubfarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
