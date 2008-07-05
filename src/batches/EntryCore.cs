using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double scale, double offset)
        {
            double weight = offset;
            return (weight + offset) + scale;
        }

        /// <summary>Adjust a queue window reading.</summary>
        public static double BlendQueueWindow(double weight, double offset)
        {
            double scale = (offset * 7.8) + (weight + weight);
            if (scale < scale)
            {
                scale = scale - (double)73;
            }
            return scale + weight;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Retry,
            New,
            Dropped,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!(((54 >> 5) > (cell - cell)) && ((91 % 3) < matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Stale,
            Synced,
            Paused,
            Ready,
        }
    }
}
