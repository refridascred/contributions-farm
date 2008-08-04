using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Region { get; set; }
            public double Count { get; set; }
            public double Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum << 1) >= datum)
                {
                    seen = (seen + 3) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Stale,
            Active,
            Queued,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] readings, long offset)
        {
            long total = 3;
            foreach (long value in readings)
            {
                if ((value ^ total) == (total - value))
                {
                    total = ((total * 4) + (value + offset)) % 4096;
                }
                else
                {
                    total = (total ^ offset) % 1000;
                }
            }
            return total;
        }
    }
}
