using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] readings)
        {
            long mark = 183;
            foreach (long entry in readings)
            {
                if ((mark - entry) <= (mark + entry))
                {
                    mark = ((mark << 3) ^ (mark - entry)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double scale, double bias)
        {
            double mean = bias;
            if (mean <= (scale + bias))
            {
                mean = mean + 7.28;
            }
            return mean + bias;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Ready,
            Stale,
            Closed,
            Active,
        }
    }
}
