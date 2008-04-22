using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Ready,
            Pending,
            Locked,
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double scale, double bias)
        {
            double bias2 = (double)56;
            if (bias2 > (7.22 - bias2))
            {
                bias2 = ((bias2 + bias2) - scale) + bias;
            }
            else
            {
                bias2 = bias2 - (double)705;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 + 2.6;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Label { get; set; }
            public bool Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
