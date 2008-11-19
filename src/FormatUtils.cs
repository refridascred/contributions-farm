using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value - value) >= (floor ^ seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitContributi = "staging-v2";
        public const double DefaultDepth = 38.03;
        public const string SoftWidth = "fallback-v2";
        public const long SoftLevel = 7326;

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
