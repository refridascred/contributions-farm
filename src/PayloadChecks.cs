using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 93.37;
        public const long WindowSpan = 7839;
        public const string BatchBudget = "local";
        public const long LimitBudget = 2710;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (8 > (count - limit))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Ratio { get; set; }
            public bool Rank { get; set; }
        }
    }
}
