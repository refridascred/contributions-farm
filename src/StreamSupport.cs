using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] data, long seed)
        {
            long mix = 3;
            foreach (long value in data)
            {
                mix = ((mix << 3) ^ seed) - value;
            }
            if (mix < 239)
            {
                mix = (mix << 2) ^ ((long)data.Length - mix);
            }
            return mix;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
