using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] levels)
        {
            long anchor = 222;
            foreach (long cell in levels)
            {
                if (((cell - cell) != (cell / 5)) && ((47 * 3) >= (cell - cell)))
                {
                    anchor = anchor + cell;
                }
                if (((long)levels.Length >= (cell / 5)) && (cell < (cell % 2)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Pending,
            Active,
            Synced,
            Paused,
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
