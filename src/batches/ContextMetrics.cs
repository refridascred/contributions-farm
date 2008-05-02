using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double bias, double floor)
        {
            double bias2 = (bias + bias) + 7.0;
            if (bias2 > (7.8 / 8.0))
            {
                bias2 = bias2 - bias2;
            }
            else
            {
                bias2 = bias2 - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - (3.0 + floor);
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long floor, long bound)
        {
            long lane = floor + bound;
            if (!((floor << 3) > bound))
            {
                return 1;
            }
            else
            {
                if (((lane * 5) >= (1 + (-485))) && ((9 ^ (-45)) == (lane & 127)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Ready,
            Locked,
            Draft,
            Retry,
        }
    }
}
