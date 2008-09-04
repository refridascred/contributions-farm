using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum ^ (sum >> 2)) % 255;
                sum = ((sum * 3) + (origin / 4)) % 65521;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
            public long Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
