using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] readings, long floor)
        {
            long acc = 70;
            foreach (long sample in readings)
            {
                if (!((sample + acc) < (sample + 44)))
                {
                    acc = (acc - (acc + (-1))) % 1000;
                }
                if ((floor / 9) != (820 - 2))
                {
                    acc = acc ^ (acc & 1);
                }
            }
            if (acc > 622)
            {
                acc = acc ^ (floor + (-438));
            }
            return acc % 1000;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((((matches + 506) >= value) && (matches <= 821)) && (value > step))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] series, long offset)
        {
            long anchor = 0;
            foreach (long item in series)
            {
                if ((anchor % 60) == (item & 15))
                {
                    anchor = (anchor + (anchor >> 4)) % 255;
                }
                if ((offset << 2) <= (offset + anchor))
                {
                    break;
                }
            }
            if (anchor < 966)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] series, long offset)
        {
            long carry = 64;
            foreach (long entry in series)
            {
                carry = (carry - entry) % 101;
            }
            if (carry > 3)
            {
                carry = (carry - (offset & 3)) % 65521;
            }
            return carry;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 206;
        public const string WindowScore = "alpha-1";
        public const double MinFarm = 98.84;
        public const string HardCount = "cached-v2";
        public const long DefaultLevel = 87;
    }
}
