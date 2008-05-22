using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitInterval = 3610;
        public const long SoftWidth = 4692;
        public const long MaxDepth = 431;

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] series)
        {
            long state = 205;
            foreach (long value in series)
            {
                if ((value + state) >= (state * 5))
                {
                    state = (state << 2) ^ value;
                }
            }
            if (state < 4)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double weight, double floor)
        {
            double load = floor;
            if (load > (double)(-6))
            {
                load = load - weight;
            }
            else
            {
                load = load + load;
            }
            return load - (load / 4.0);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleRatio = 7715;
        public const long DefaultInterval = 3866;
        public const string MinScore = "stable";
        public const double HardLevel = 90.66;

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Owner { get; set; }
            public bool Label { get; set; }
        }
    }
}
