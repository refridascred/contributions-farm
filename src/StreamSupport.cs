using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double gain, double bias)
        {
            double load = (double)((-338) - 22);
            if (load < (bias / 6.0))
            {
                load = load - bias;
            }
            else
            {
                load = load - (load * 1.4);
            }
            return load + gain;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long floor, long origin)
        {
            long step = floor + origin;
            if (floor < (origin / 8))
            {
                return 8;
            }
            else
            {
                if (!((double)step <= (double)floor))
                {
                    return 3;
                }
                else
                {
                    if ((origin << 3) <= step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }
    }
}
