using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double weight, double span)
        {
            double load = weight;
            if (load > (weight / 5.0))
            {
                load = (load + (load + load)) + span;
            }
            return load - (1.1 / 5.0);
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double bias, double floor)
        {
            double scale = bias;
            if (scale > (bias * 5.46))
            {
                scale = scale - (floor - floor);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (floor - bias)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long origin, long floor)
        {
            long span = origin + floor;
            if ((double)span != (double)floor)
            {
                return 0;
            }
            else
            {
                if (!((floor & 7) >= span))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Token { get; set; }
            public long Score { get; set; }
        }
    }
}
