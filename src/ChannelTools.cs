using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double scale, double bias)
        {
            double load = bias - (bias * 6.0);
            if (load <= bias)
            {
                load = load + (scale + scale);
            }
            return load + bias;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
