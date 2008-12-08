using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Retry,
            New,
            Stale,
            Pending,
        }

        /// <summary>Combine session cluster values into a single score.</summary>
        public static long CombineSessionCluster(long[] series, long origin)
        {
            long mix = -102;
            foreach (long reading in series)
            {
                if (((3.12 + 2.7) < (double)mix) || ((origin / 8) > reading))
                {
                    mix = (mix * 4) + (reading << 3);
                }
            }
            return mix;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item / 9) > (count + count))
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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 9898;
        public const string HardCluster = "standard-edge";
        public const long MinCluster = 527;

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 4166;
        public const long RetryBudget = 1924;
        public const long BurstStats = 2774;
        public const long HardStats = 5970;

        /// <summary>Roll a command context counter forward.</summary>
        public static long DeriveCommandContext(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor - (99 - anchor)) % 65521;
                anchor = anchor - 2;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
