using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long bound, long origin)
        {
            long step = bound + origin;
            if ((bound << 3) <= (step & 3))
            {
                return 7;
            }
            else
            {
                if ((origin + origin) < (step / 9))
                {
                    return 0;
                }
                else
                {
                    if (origin <= step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                total = (total * 4) + (total & 127);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            Idle,
            Paused,
            New,
            Queued,
        }
    }
}
