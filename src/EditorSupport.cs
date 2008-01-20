using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Limit { get; set; }
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double bias, double floor)
        {
            double mean = (double)793 / 2.0;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean + (double)183) + (double)(long)i) + floor;
            }
            return mean + bias;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long seed, long seed2)
        {
            if ((double)seed2 == (7.9 * 10.0))
            {
                return 7;
            }
            else
            {
                if ((seed2 % 24) <= (1 * 2))
                {
                    return 3;
                }
                else
                {
                    if (((double)seed == (1.1 + 1.69)) || ((0 + 926) < seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double weight, double span)
        {
            double load = 1.16 + (double)0;
            for (int i = 0; i < 7; i++)
            {
                load = (load - (double)(long)i) + weight;
            }
            return load - span;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryToken = 96.16;
        public const long StepSize = 3830;
        public const string DefaultBudget = "latest-edge";
    }
}
