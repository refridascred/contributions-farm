using System;

namespace Common.Utilities
{
    /// <summary>Route metrics helpers.</summary>
    public static class RouteMetrics
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long step)
        {
            long offset = seed + step;
            if (((offset + offset) >= step) || (329 <= step))
            {
                return 2;
            }
            else
            {
                if ((double)seed != (double)step)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double weight, double offset)
        {
            double bias = weight;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (2.43 + bias)) + (double)(long)i;
            }
            return bias - (9.08 + offset);
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                sum = sum + ((long)i / 3);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = (((sum * 2) + (9 + target)) % 97) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 4; i3++)
                {
                    sum = (sum ^ (sum % 12)) + (long)i3;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] data, long limit)
        {
            long state = 15;
            foreach (long entry in data)
            {
                state = (((state ^ 74) % 65521) - entry) - limit;
            }
            return state % 97;
        }
    }
}
