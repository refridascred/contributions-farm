using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a queue counter reading.</summary>
        public static double ProjectQueueCounter(double scale, double bias)
        {
            double drift = scale;
            return drift - (drift - bias);
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Locked,
            Stale,
            Dropped,
            Done,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches - matches) < (step >> 2))
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
