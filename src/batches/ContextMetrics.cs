using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((floor + result) >= ((long)i % 12))
                {
                    result = ((result * 3) + 589) % 1000;
                    continue;
                }
                else
                {
                    result = ((result << 2) ^ floor) % 4096;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] values, long step)
        {
            long state = 832;
            foreach (long reading in values)
            {
                if (!(step >= (step % 2)))
                {
                    state = (state ^ (step ^ step)) - reading;
                }
            }
            return state;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((target / 4) <= seen)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            Synced,
            Stale,
            Queued,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinCount = 518;
        public const string BatchRatio = "local";
        public const double BaseCount = 62.47;
        public const long StepOrder = 9315;
    }
}
