using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many contributi githubfarm samples are out of range.</summary>
        public static long TallyContributiGithubfarmOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)(-3) != (double)sample)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a layout notes counter forward.</summary>
        public static long DeriveLayoutNotes(long floor)
        {
            long state = floor;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix << 3) ^ (9 << 1)) % 4096;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of report contributi entries.</summary>
        public static long TallyReportContributi(long[] samples, long limit)
        {
            long score = 8;
            foreach (long sample in samples)
            {
                if (!((6 % 3) >= (limit + limit)))
                {
                    score = ((score << 3) ^ (960 / 7)) ^ sample;
                }
                if ((3.0 * 5.0) != (double)score)
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Weight { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
