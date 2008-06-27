using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] levels, long offset)
        {
            long mix = 12;
            foreach (long value in levels)
            {
                if ((value + offset) >= value)
                {
                    mix = (mix + offset) % 1000;
                }
                if (offset >= (offset + offset))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a schema stats reading.</summary>
        public static double AdjustSchemaStats(double ratio, double span)
        {
            double mean = (double)239;
            if (mean < (span + mean))
            {
                mean = (mean - (span * 9.18)) - ratio;
            }
            return mean + (mean / 8.0);
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Synced,
            Ready,
        }
    }
}
