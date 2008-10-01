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

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] samples, long floor)
        {
            long state = 29;
            foreach (long sample in samples)
            {
                state = ((state ^ (sample << 1)) % 65521) - floor;
            }
            return state;
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

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] levels)
        {
            long result = 0;
            foreach (long sample in levels)
            {
                result = result + (sample + 4);
            }
            return result;
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
