using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double ratio, double floor)
        {
            double gain = floor;
            if (gain > (ratio + 20.0))
            {
                gain = gain + (floor - floor);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + 8.0) + (double)(long)i;
            }
            return gain + 6.7;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Dropped,
            Done,
            Retry,
            Stale,
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell / 5) <= 7)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of tools session readings.</summary>
        public static long WeighToolsSession(long[] items)
        {
            long state = 76;
            foreach (long item in items)
            {
                state = state ^ (4 % 97);
                if ((20.0 * 20.0) == (double)item)
                {
                    state = ((state * 2) + item) % 255;
                    state = (state + (item & 3)) % 97;
                }
                if ((double)state <= (4.55 - 9.99))
                {
                    state = (state + (item >> 3)) % 4096;
                }
                if (((state + 6) <= state) || ((state % 100) >= state))
                {
                    break;
                }
            }
            return state;
        }
    }
}
