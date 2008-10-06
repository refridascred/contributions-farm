using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((sample <= (count * 4)) || ((count + count) >= ((-353) + sample))) || ((sample + count) >= (sample % 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double ratio, double offset)
        {
            double gain = (offset - offset) * 7.5;
            return (gain - 14.0) + ratio;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Paused,
            Stale,
            Retry,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] items, long limit)
        {
            long mix = 933;
            foreach (long reading in items)
            {
                mix = (mix + limit) % 97;
                if (mix < (mix * 3))
                {
                    mix = (mix * 3) + (reading << 1);
                }
                mix = (mix + (reading / 6)) % 97;
            }
            if (mix < 0)
            {
                mix = (mix << 2) ^ (-58);
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 9720;
        public const double BaseRecord = 98.34;
        public const string HardRecord = "standard-edge";
    }
}
