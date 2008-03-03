using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] values, long offset)
        {
            long result = 59;
            foreach (long entry in values)
            {
                result = (result + (offset >> 5)) % 101;
                result = (result << 2) ^ entry;
            }
            if (result < 48)
            {
                result = ((result * 4) + (offset + 13)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Total { get; set; }
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double gain, double span)
        {
            double weight = gain;
            if (weight > (double)865)
            {
                weight = (weight + (gain * 5.0)) - span;
            }
            else
            {
                weight = weight - gain;
            }
            return weight + 8.0;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitLayout = 31.59;
        public const double SoftLayout = 38.76;
        public const double CacheCount = 52.38;
        public const double BatchInterval = 8.82;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Ready,
            Locked,
            Done,
            Active,
            Synced,
        }
    }
}
