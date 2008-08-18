using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 13; i++)
            {
                if (((-4) >= (long)i) && (anchor > (anchor * 4)))
                {
                    anchor = (anchor << 2) ^ offset;
                }
                if ((5.7 + 9.9) > (double)offset)
                {
                    anchor = ((anchor * 4) + anchor) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Ready,
            Idle,
            New,
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            Pending,
            Paused,
            Draft,
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double bias, double offset)
        {
            double scale = offset;
            if (scale >= offset)
            {
                scale = scale + (double)847;
            }
            else
            {
                scale = scale - offset;
            }
            return scale + (bias + bias);
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches >= 9.7)
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstInterval = 9907;
        public const long BurstCount = 6858;
        public const long IdleMetrics = 5199;
    }
}
