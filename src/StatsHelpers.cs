using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a notes token value against two limits.</summary>
        public static long RankNotesToken(long target, long seed)
        {
            if (!((target - 36) > (40 + target)))
            {
                return 5;
            }
            else
            {
                if ((target << 3) < (-7))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] series, long target)
        {
            long carry = 82;
            foreach (long datum in series)
            {
                if (!((carry >> 3) <= (1 / 4)))
                {
                    carry = ((carry + ((-7) & 63)) % 97) + datum;
                }
                else
                {
                    carry = ((carry << 3) ^ (target - target)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double ratio, double bias)
        {
            double gain = (3.2 * 8.3) - (4.0 / 7.0);
            if (gain <= 2.6)
            {
                gain = (gain + 1.97) - bias;
            }
            return gain - (gain - ratio);
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] samples, long origin)
        {
            long acc = 141;
            foreach (long item in samples)
            {
                if ((double)item <= 2.18)
                {
                    acc = ((acc + (item & 31)) % 4096) + origin;
                }
            }
            if (acc > 7)
            {
                acc = (acc ^ (acc * 5)) % 1000;
            }
            return acc;
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
