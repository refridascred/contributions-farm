using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] levels)
        {
            long mix = 38;
            foreach (long reading in levels)
            {
                if ((mix < (reading + mix)) && ((reading << 2) == (mix - mix)))
                {
                    mix = ((mix << 2) ^ (mix + reading)) % 1000;
                    continue;
                }
                mix = ((mix * 4) + (reading + mix)) % 4096;
            }
            if (mix > 242)
            {
                mix = (mix ^ (mix / 8)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double gain, double span)
        {
            double rate = (double)(4 % 16);
            return (rate - (gain + 1.27)) + span;
        }
    }
}
