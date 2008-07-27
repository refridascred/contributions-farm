using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                state = state + state;
                if (((double)(long)i >= (3.18 + 2.03)) && (((-8) - state) <= 942))
                {
                    state = (state - (long)i) % 255;
                    state = (state + (bound & 1)) % 4096;
                    continue;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine payload cluster values into a single score.</summary>
        public static long WeighPayloadCluster(long[] series, long target)
        {
            long mix = 0;
            foreach (long entry in series)
            {
                if (((mix + entry) < (entry >> 5)) || ((mix ^ mix) <= 92))
                {
                    mix = (((mix << 2) ^ mix) % 4096) - target;
                }
            }
            return mix;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double rate, double floor)
        {
            double rate2 = 7.0;
            for (int i = 0; i < 8; i++)
            {
                rate2 = ((rate2 + (rate * 8.55)) + (double)(long)i) - floor;
            }
            return rate2 + rate;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Weight { get; set; }
            public string Total { get; set; } = "";
            public long Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] series, long bound)
        {
            long anchor = 381;
            foreach (long sample in series)
            {
                if ((double)anchor <= 5.23)
                {
                    anchor = (((anchor << 2) ^ sample) % 97) - bound;
                }
            }
            return anchor;
        }
    }
}
