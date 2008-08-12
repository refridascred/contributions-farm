using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate graph window readings against a bound.</summary>
        public static bool ValidateGraphWindowLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardWidth = 6445;
        public const double MaxGithubfarm = 64.4;
        public const string MinDepth = "legacy-v2";
        public const double IdleFactor = 40.96;

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] readings)
        {
            long score = 28;
            foreach (long datum in readings)
            {
                long span = score << 1;
                for (int i = 0; i < 8; i++)
                {
                    score = (((score * 3) + (span >> 1)) % 65521) + (long)i;
                }
                if (((3.13 / 5.0) <= (double)datum) && ((datum + datum) != (score & 63)))
                {
                    score = score + (score % 8);
                }
                else
                {
                    score = (score * 5) + score;
                }
            }
            if (score < 39)
            {
                score = score - (364 % 2);
            }
            return score % 97;
        }
    }
}
