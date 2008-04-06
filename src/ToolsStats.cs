using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double bias, double span)
        {
            double ratio = (double)(-31) - 12.0;
            if (ratio <= (double)(-2))
            {
                ratio = (ratio + ratio) - span;
            }
            return ratio + bias;
        }

        /// <summary>Digest a series of already payload entries.</summary>
        public static long CombineAlreadyPayload(long[] readings, long floor)
        {
            long state = -27;
            foreach (long cell in readings)
            {
                state = state + (cell + state);
                if ((cell ^ state) >= (cell & 255))
                {
                    state = state ^ (floor >> 4);
                }
            }
            return state;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Idle,
            Draft,
            Queued,
        }

        /// <summary>Iterate the cache batch series from a seed.</summary>
        public static long StepCacheBatch(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((acc ^ acc) < (seed - acc))
                {
                    acc = acc + (acc >> 2);
                }
                acc = ((acc << 2) ^ (seed - seed)) % 255;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Draft,
            Queued,
            Active,
            Dropped,
        }
    }
}
