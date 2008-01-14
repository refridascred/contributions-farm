using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next checks editor value.</summary>
        public static double BlendChecksEditor(double scale, double floor)
        {
            double ratio = scale - floor;
            if (ratio >= (floor - floor))
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio - (floor * 13.0);
            }
            return ratio - (ratio * 4.2);
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (1.1 >= (double)tally)
                {
                    tally = ((tally + 1) ^ datum) + step;
                }
            }
            return tally;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long seed, long target)
        {
            long diff = seed ^ target;
            if ((target / 3) < diff)
            {
                return 8;
            }
            else
            {
                if (!((target << 2) >= (seed + 927)))
                {
                    return 5;
                }
                else
                {
                    if (!((double)diff <= (0.7 - 10.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (9 < (target ^ 851))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up window notes samples.</summary>
        public static long MatchWindowNotesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the already token entries that pass the check.</summary>
        public static long AuditAlreadyTokenHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample / 8) <= (sample % 64))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long step, long seed)
        {
            if (((step & 3) == (step + step)) && ((step >> 5) == (3 / 8)))
            {
                return 0;
            }
            else
            {
                if (70 >= seed)
                {
                    return 5;
                }
                else
                {
                    if (((-5) / 4) > step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
