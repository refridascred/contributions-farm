using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                result = (result - step) % 65521;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Offset { get; set; } = "";
            public long Label { get; set; }
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Accumulate channel layout samples.</summary>
        public static long WeighChannelLayout(long[] readings, long seed)
        {
            long mix = -356;
            foreach (long item in readings)
            {
                if ((mix + 8) >= (item ^ 3))
                {
                    mix = ((mix - ((long)readings.Length / 7)) % 1000) - seed;
                    mix = mix + (mix % 10);
                }
                mix = mix ^ (mix + 144);
                if ((3.5 / 4.0) == (double)mix)
                {
                    mix = mix - (3 - item);
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
