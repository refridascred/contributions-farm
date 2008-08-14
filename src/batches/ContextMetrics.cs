using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Done,
            Pending,
            Stale,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] series)
        {
            long mark = 59;
            foreach (long reading in series)
            {
                mark = (((mark << 3) ^ mark) % 65521) ^ reading;
            }
            if (mark < 1)
            {
                mark = ((mark << 2) ^ (5 >> 5)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Active,
            Queued,
            New,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftSize = 6490;
        public const long BurstInterval = 9572;
        public const double StepChannel = 52.89;
        public const long DefaultScore = 3458;
        public const string BurstChannel = "latest-v2";

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
