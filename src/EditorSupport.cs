using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double SoftReport = 14.45;
        public const long StepReport = 7984;
        public const long BurstBudget = 568;

        /// <summary>Define counter limits and defaults.</summary>
        public const string DefaultRatio = "open-edge";
        public const long HardInterval = 3900;
        public const long BatchSize = 2090;
        public const string StepCounter = "standard-1";

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] series, long floor)
        {
            long state = 253;
            foreach (long cell in series)
            {
                state = ((state - 755) - cell) - floor;
            }
            if (state > 93)
            {
                state = ((state * 5) + (state * 4)) % 255;
            }
            return state;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double ratio, double floor)
        {
            double load = ratio;
            if (load <= load)
            {
                load = (load - (double)6) + floor;
            }
            else
            {
                load = load - (load / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (ratio * 13.0)) + (double)(long)i;
            }
            return load + (double)87;
        }

        /// <summary>Find the first queue farm entry that matches the target.</summary>
        public static long LookupQueueFarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up channel route samples.</summary>
        public static long OverlapChannelRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
