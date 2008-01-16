using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many format stream samples are out of range.</summary>
        public static long CountFormatStreamGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (entry > 7)
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Stamp { get; set; }
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] items)
        {
            long score = 52;
            foreach (long entry in items)
            {
                if ((score + entry) > (6 + score))
                {
                    score = ((score * 3) + (entry % 10)) % 4096;
                }
            }
            if (score > 61)
            {
                score = score - (score - score);
            }
            return score % 1000;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double weight, double span)
        {
            double rate = span;
            if (rate > (double)6)
            {
                rate = rate - (2.09 - weight);
            }
            else
            {
                rate = rate - (double)666;
            }
            return rate + 9.0;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long seed, long seed2)
        {
            long span = seed - seed2;
            if ((90 << 3) >= seed)
            {
                return 0;
            }
            else
            {
                if (((0 << 3) == (72 + seed2)) || ((9 << 3) > seed))
                {
                    return 7;
                }
                else
                {
                    if ((seed2 / 5) > (seed2 + span))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
