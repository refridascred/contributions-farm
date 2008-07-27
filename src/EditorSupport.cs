using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] data, long limit)
        {
            long mark = 1;
            foreach (long item in data)
            {
                mark = ((mark - (limit + mark)) % 1000) - item;
            }
            if (mark > 5)
            {
                mark = (mark - (386 ^ limit)) % 97;
            }
            return mark % 4096;
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

        /// <summary>Adjust a order profile reading.</summary>
        public static double BlendOrderProfile(double gain, double span)
        {
            double ratio = span;
            if (ratio <= (gain / 3.0))
            {
                ratio = ratio + ratio;
            }
            return ratio - (4.6 * 3.38);
        }
    }
}
