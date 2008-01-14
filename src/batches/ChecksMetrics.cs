using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] series, long seed)
        {
            long mix = 228;
            foreach (long datum in series)
            {
                mix = (mix - (mix - seed)) - datum;
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepChannel = "staging-1";
        public const long MinChannel = 4916;
        public const long RetryRatio = 7106;
        public const double HardChannel = 22.48;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Active,
            Failed,
            Draft,
            Closed,
        }

        /// <summary>Count the editor schema entries that pass the check.</summary>
        public static long AuditEditorSchemaHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches < (matches / 6)) || !((item - item) <= (matches % 12)))
                {
                    matches = (matches + 3) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next channel command value from a seed.</summary>
        public static long DeriveChannelCommand(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
