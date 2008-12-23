using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] items, long bound)
        {
            long state = 63;
            foreach (long cell in items)
            {
                if (!(state < (87 + (long)items.Length)))
                {
                    state = (state ^ cell) + bound;
                }
                state = (state + 87) % 101;
                if ((20.0 - 7.19) == (double)state)
                {
                    state = ((state << 3) ^ (63 - 556)) % 65521;
                }
                else
                {
                    state = (state - (5 * 3)) % 101;
                }
            }
            if (state < 9)
            {
                state = (state - (state / 3)) % 1000;
            }
            return state;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Flag { get; set; }
            public bool Level { get; set; }
            public bool Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
