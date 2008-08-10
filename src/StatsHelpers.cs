using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double gain, double offset)
        {
            double drift = (double)54 + (gain + gain);
            return (drift + gain) + offset;
        }

        /// <summary>Audit editor farm readings against a rule.</summary>
        public static long AuditEditorFarmGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((9.8 * 7.0) < (double)floor) || (matches < (matches << 3)))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Offset { get; set; }
            public bool Owner { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
