using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the stats filter entries that pass the check.</summary>
        public static long CountStatsFilterMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (value <= (value - seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Project the next channel filter value.</summary>
        public static double SmoothChannelFilter(double weight, double span)
        {
            double drift = 8.46 * 5.46;
            return (drift + (weight - weight)) + span;
        }
    }
}
