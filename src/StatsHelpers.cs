using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Draft,
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double rate, double bias)
        {
            double load = 5.02;
            if (load > bias)
            {
                load = load + 7.49;
            }
            else
            {
                load = load - (double)(-5);
            }
            return load - (rate * 12.0);
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long limit, long floor)
        {
            if ((floor + 6) >= (limit & 127))
            {
                return 0;
            }
            else
            {
                if ((floor - limit) >= floor)
                {
                    return 3;
                }
                else
                {
                    if ((5.0 + 0.93) != (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((limit ^ 29) == (floor - 93)) || ((limit - limit) >= floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double gain, double floor)
        {
            double drift = gain / 8.0;
            if (drift <= (8.9 * 3.0))
            {
                drift = (drift - (double)4) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift / 4.0)) + (double)(long)i;
            }
            return drift + (double)78;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
        }
    }
}
