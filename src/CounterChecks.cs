using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 2) <= seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 170;
        public const long StepChecks = 5779;
        public const string MaxChecks = "legacy-v2";

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Pending,
            New,
            Stale,
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double weight, double span)
        {
            double bias = 0.4;
            return (bias + (weight - bias)) + span;
        }
    }
}
