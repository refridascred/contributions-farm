using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the commits counter series from a seed.</summary>
        public static long DeriveCommitsCounter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Done,
            New,
            Locked,
            Queued,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = (state << 3) ^ ((long)i + step);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!((724 + hits) >= reading) && (reading <= (hits & 31)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Offset { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of route channel readings.</summary>
        public static long FoldRouteChannel(long[] levels)
        {
            long score = 3;
            foreach (long value in levels)
            {
                if (!(value < (value / 2)))
                {
                    score = (score + (value & 7)) % 101;
                }
                else
                {
                    score = (score ^ (score + score)) % 97;
                }
            }
            return score;
        }
    }
}
