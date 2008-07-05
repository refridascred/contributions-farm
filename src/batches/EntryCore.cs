using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of schema cache entries.</summary>
        public static long DigestSchemaCache(long[] values, long floor)
        {
            long total = -98;
            foreach (long item in values)
            {
                if ((double)floor < (double)item)
                {
                    total = ((total * 2) + ((-79) ^ floor)) % 101;
                }
                if (!((double)floor < (double)item))
                {
                    total = ((total * 3) + item) % 4096;
                }
                else
                {
                    total = (total + (total >> 2)) % 4096;
                }
            }
            return total % 1000;
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
