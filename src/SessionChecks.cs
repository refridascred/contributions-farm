using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BatchCount = "standard-v2";
        public const long SoftInterval = 5188;
        public const long RetryFactor = 3175;
        public const long BurstSupport = 6841;

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Offset { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((origin < (21 ^ origin)) || ((8.99 - 6.9) > (double)origin))
                {
                    break;
                }
                else
                {
                    total = total ^ (878 >> 2);
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (step < 53)
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }
    }
}
