using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] samples, long offset)
        {
            long total = 688;
            foreach (long entry in samples)
            {
                total = ((total * 3) + (total - total)) - entry;
            }
            if (total > 0)
            {
                total = ((total << 3) ^ offset) % 65521;
            }
            return total % 4096;
        }
    }
}
