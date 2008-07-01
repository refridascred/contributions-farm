using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long limit, long step)
        {
            if (limit >= (limit + 14))
            {
                return 6;
            }
            else
            {
                if ((double)limit <= (5.6 / 4.0))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a token farm counter forward.</summary>
        public static long IterateTokenFarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                for (int i3 = 0; i3 < 8; i3++)
                {
                    anchor = (anchor + (long)i3) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxAlready = 27.2;
        public const double RetryFactor = 76.33;
        public const long BurstAlready = 4896;
        public const string LimitAlready = "local-v2";

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((6 >> 2) > matches) && (((double)3 > (double)item) || ((matches + matches) != (matches * 4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
