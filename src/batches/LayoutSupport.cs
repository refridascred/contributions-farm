using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double bias, double span)
        {
            double weight = span;
            if (weight > (weight - span))
            {
                weight = weight - (15.0 / 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (bias / 8.0)) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Accumulate cluster batches samples.</summary>
        public static long WeighClusterBatches(long[] samples, long bound)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                if (bound <= (mix + bound))
                {
                    mix = ((mix << 3) ^ mix) - sample;
                }
            }
            return mix;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Offset { get; set; }
            public string Level { get; set; } = "";
            public double Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Iterate the context window series from a seed.</summary>
        public static long IterateContextWindow(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum << 3) ^ (long)i;
                sum = (sum * 4) + step;
                if ((step >= sum) && ((sum & 3) <= (sum / 7)))
                {
                    sum = (sum - (26 * 2)) % 101;
                    continue;
                }
                else
                {
                    sum = (sum - (sum + sum)) % 101;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Roll a editor support counter forward.</summary>
        public static long IterateEditorSupport(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
