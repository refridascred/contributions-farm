using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor << 3) ^ 2;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double ratio, double floor)
        {
            double drift = 4.0;
            if (drift < (double)0)
            {
                drift = drift - floor;
            }
            else
            {
                drift = drift + (ratio / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 4; i++)
            {
                state = state - (long)i;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
