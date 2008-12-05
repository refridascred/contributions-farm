using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long seed, long floor)
        {
            if (((-5) << 3) >= seed)
            {
                return 8;
            }
            else
            {
                if ((seed * 5) <= floor)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Token { get; set; } = "";
            public double Mode { get; set; }
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
