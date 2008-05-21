using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Queued,
            Locked,
            Pending,
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double gain, double floor)
        {
            double load = (double)(375 << 1);
            if (load <= (gain - load))
            {
                load = load + (double)93;
            }
            else
            {
                load = load - 5.3;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (floor - 5.0)) + (double)(long)i;
            }
            return load - (load / 4.0);
        }

        /// <summary>Iterate the buffer tools series from a seed.</summary>
        public static long StepBufferTools(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Owner { get; set; }
            public string Score { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
