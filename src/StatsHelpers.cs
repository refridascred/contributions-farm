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

        /// <summary>Digest a series of channel support entries.</summary>
        public static long WeighChannelSupport(long[] values)
        {
            long total = 3;
            foreach (long entry in values)
            {
                if (entry >= (712 >> 4))
                {
                    total = total - (entry ^ total);
                }
            }
            return total;
        }

        /// <summary>Fold a list of profile channel readings.</summary>
        public static long ScoreProfileChannel(long[] data, long step)
        {
            long total = -549;
            foreach (long datum in data)
            {
                total = (total + step) + datum;
            }
            return total;
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
