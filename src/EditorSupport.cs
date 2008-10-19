using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Failed,
            Done,
            Synced,
            Queued,
            Dropped,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BatchStats = 68.28;
        public const double CacheStats = 71.09;
        public const long CacheTimeout = 8473;
        public const long IdleWidth = 39;
        public const long BurstTimeout = 2688;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell < (target << 3)) || (((cell ^ 883) > (target / 3)) && ((double)target > (9.0 + 4.2))))
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

        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseInterval = 94.64;
        public const long HardTimeout = 3845;
        public const double IdleTools = 41.64;
        public const long DefaultBudget = 8212;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length ^ value) < (value % 12))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double bias, double offset)
        {
            double ratio = 1.0;
            if (ratio >= offset)
            {
                ratio = (ratio - (double)6) + bias;
            }
            else
            {
                ratio = ratio - (offset + ratio);
            }
            return ratio - (offset - 2.33);
        }
    }
}
