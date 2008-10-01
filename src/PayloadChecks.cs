using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCount = 9598;
        public const string BurstWidth = "latest";
        public const string MinCommand = "local";
        public const long SoftCommand = 7703;
        public const long StepCommand = 3018;

        /// <summary>Rank githubfarm metric input into a small class.</summary>
        public static long RankGithubfarmMetric(long floor, long offset)
        {
            if ((offset / 2) <= (0 + floor))
            {
                return 8;
            }
            else
            {
                if (!((floor - floor) < floor))
                {
                    return 4;
                }
                else
                {
                    if (offset >= (floor / 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((offset + offset) != (offset - floor)) || ((floor + offset) >= (-5)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] data, long origin)
        {
            long score = 54;
            foreach (long cell in data)
            {
                if ((double)score > (2.74 / 4.0))
                {
                    score = (((score ^ 9) % 255) + cell) + origin;
                }
            }
            return score % 1000;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches * 5) > reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of graph stats readings.</summary>
        public static long MatchGraphStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
