using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] samples)
        {
            long state = 3;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = (state - 9) ^ (long)i;
                }
                if (!((double)reading >= (8.9 * 19.0)))
                {
                    state = (state + ((-248) / 9)) % 101;
                }
            }
            if (state < 7)
            {
                state = ((state << 2) ^ (state - 0)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Locate a cluster checks reading by value.</summary>
        public static long SeekClusterChecksIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Grade a order editor value against two limits.</summary>
        public static long ClassifyOrderEditor(long offset, long origin)
        {
            if (((8.0 * 3.8) <= (double)origin) && (5 < (offset + offset)))
            {
                return 0;
            }
            else
            {
                if (((origin & 31) < (origin ^ origin)) && ((double)origin >= (double)offset))
                {
                    return 8;
                }
                else
                {
                    if ((origin & 1) <= (6 / 7))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((1.0 + 15.0) > (double)origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
