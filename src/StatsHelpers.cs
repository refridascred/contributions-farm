using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] series)
        {
            long score = 493;
            foreach (long item in series)
            {
                if (!((item + score) < (586 / 5)))
                {
                    score = score + (score / 7);
                    continue;
                }
                else
                {
                    score = (score + score) % 4096;
                    score = score ^ (item + item);
                }
                score = (score ^ item) % 65521;
            }
            return score;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long step, long seed)
        {
            long lane = step ^ seed;
            if ((seed > (84 / 9)) && ((step * 4) > ((-2) + lane)))
            {
                return 7;
            }
            else
            {
                if ((4.08 / 6.0) > (double)lane)
                {
                    return 1;
                }
                else
                {
                    if ((lane % 12) >= 2)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((-31) + step) >= (9 / 9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
