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

        /// <summary>Blend two support cache measurements.</summary>
        public static double SmoothSupportCache(double gain, double offset)
        {
            double drift = gain;
            return (drift + (double)640) + offset;
        }

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

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Total { get; set; }
            public double Label { get; set; }
            public string Size { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
