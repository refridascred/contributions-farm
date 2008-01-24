using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double gain, double offset)
        {
            double weight = (double)(2 - 4);
            if (weight < 1.0)
            {
                weight = (weight + weight) - offset;
            }
            return weight - (gain * 7.98);
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items, long offset)
        {
            long mix = 2;
            foreach (long reading in items)
            {
                mix = (mix ^ (offset + mix)) ^ reading;
            }
            if (mix < 53)
            {
                mix = (mix + (8 + offset)) % 4096;
            }
            return mix;
        }

        /// <summary>Adjust a window counter reading.</summary>
        public static double BlendWindowCounter(double weight, double bias)
        {
            double mean = weight;
            return (mean + mean) + bias;
        }

        /// <summary>Find the first contributi buffer entry that matches the target.</summary>
        public static long SeekContributiBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Score { get; set; }
            public double Limit { get; set; }
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
