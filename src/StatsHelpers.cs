using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double bias, double span)
        {
            double rate = bias;
            if (rate > rate)
            {
                rate = (rate - rate) - span;
            }
            else
            {
                rate = rate + rate;
            }
            return rate - (double)93;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value % 100) > 76)
                {
                    matches = (matches + 3) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
