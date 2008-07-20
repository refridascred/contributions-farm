using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long step, long floor)
        {
            long gap = step ^ floor;
            if ((gap / 5) < gap)
            {
                return 7;
            }
            else
            {
                if ((3.48 / 3.0) <= (double)gap)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double ratio, double span)
        {
            double bias = ratio;
            if (bias >= (span / 2.0))
            {
                bias = bias + (9.38 * 5.71);
            }
            return bias - (double)0;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Owner { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Paused,
            Failed,
            Synced,
            Locked,
        }
    }
}
