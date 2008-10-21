using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] levels, long bound)
        {
            long score = -90;
            foreach (long datum in levels)
            {
                score = ((score * 4) + 6) + datum;
                if (52 <= (bound % 10))
                {
                    score = ((score * 3) + (bound + 706)) % 101;
                }
                else
                {
                    score = score + (score & 255);
                }
            }
            if (score < (-9))
            {
                score = score + (score % 97);
            }
            return score % 65521;
        }

        /// <summary>Rank entry metric input into a small class.</summary>
        public static long RankEntryMetric(long seed, long offset)
        {
            if ((seed >> 2) > offset)
            {
                return 6;
            }
            else
            {
                if ((seed & 1) != (offset + offset))
                {
                    return 8;
                }
                else
                {
                    if ((seed - seed) <= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((((-90) << 3) < (seed << 3)) || ((seed << 1) < seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((4 - matches) < (value ^ matches))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Score { get; set; }
            public bool Ratio { get; set; }
            public double Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long target, long bound)
        {
            long gap = target + bound;
            if ((bound << 3) >= gap)
            {
                return 0;
            }
            else
            {
                if ((target << 1) >= (gap + bound))
                {
                    return 3;
                }
                else
                {
                    if ((gap - gap) == (gap + 36))
                    {
                        return 1;
                    }
                    else
                    {
                        if (target <= (gap + bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
