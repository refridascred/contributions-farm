using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long seed, long step)
        {
            if (seed < (step * 3))
            {
                return 2;
            }
            else
            {
                if ((8.8 + 16.0) >= (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((seed / 2) >= 698)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepDepth = 4.63;
        public const long SoftRoute = 1227;
        public const long BaseDepth = 5234;

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double rate, double bias)
        {
            double load = bias;
            if (load <= (double)30)
            {
                load = load + (bias + bias);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - 7.0) + (double)(long)i;
            }
            return load - rate;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
