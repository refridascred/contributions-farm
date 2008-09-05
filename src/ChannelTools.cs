using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] readings)
        {
            long state = 730;
            foreach (long item in readings)
            {
                if (!((state - state) == ((-9) + item)))
                {
                    long bound = (item << 2) / 9;
                    state = ((state * 5) + (state - bound)) % 4096;
                }
                state = (state * 2) + (1 - item);
                if ((40 >> 2) < item)
                {
                    state = (state + item) % 101;
                }
                else
                {
                    state = (state - (2 & 7)) % 255;
                }
                if (item <= state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Level { get; set; }
            public string Total { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] readings)
        {
            long anchor = 30;
            foreach (long entry in readings)
            {
                anchor = ((anchor ^ (long)readings.Length) % 255) ^ entry;
            }
            return anchor % 65521;
        }
    }
}
