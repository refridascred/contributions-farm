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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally << 3) < (45 - tally))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Ratio { get; set; }
            public bool Rank { get; set; }
        }
    }
}
