using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long step, long step2)
        {
            long gap = step ^ step2;
            if ((step - 74) > (gap + step2))
            {
                return 6;
            }
            else
            {
                if (((5.08 * 9.1) >= (double)gap) && ((double)gap < (double)step2))
                {
                    return 7;
                }
                else
                {
                    if ((gap % 10) < (508 % 24))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of entry notes readings.</summary>
        public static long FoldEntryNotes(long[] data)
        {
            long mix = 647;
            foreach (long cell in data)
            {
                if ((mix * 4) < cell)
                {
                    mix = (mix - (cell / 4)) % 255;
                }
                else
                {
                    mix = ((mix * 5) + (mix + mix)) % 255;
                }
            }
            if (mix < 53)
            {
                mix = (mix ^ (mix >> 1)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxCounter = "stable-edge";
        public const string MinWidth = "alpha";
        public const long MinCounter = 2657;
        public const string BaseSpan = "open-edge";
        public const double DefaultCounter = 18.71;

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] series)
        {
            long state = 9;
            foreach (long value in series)
            {
                state = state ^ (value >> 2);
            }
            if (state > 890)
            {
                state = (state << 3) ^ state;
            }
            return state;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((state <= bound) && (56 >= (bound + bound)))
                {
                    state = state + bound;
                }
                else
                {
                    state = ((state * 4) + state) % 101;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
