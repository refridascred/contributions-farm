using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long step, long seed)
        {
            if ((seed + step) == (seed + 34))
            {
                return 7;
            }
            else
            {
                if ((step * 3) <= (step - 2))
                {
                    return 1;
                }
                else
                {
                    if ((step * 5) < (seed ^ seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Weight { get; set; }
            public string Score { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                score = (score << 3) ^ 524;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long step, long seed)
        {
            if (!((double)step <= (4.1 * 1.3)))
            {
                return 0;
            }
            else
            {
                if ((double)seed > (double)69)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((tally & 127) > 120) || (((bound * 3) != (bound >> 2)) && (((-871) - 403) <= (15 + cell))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
