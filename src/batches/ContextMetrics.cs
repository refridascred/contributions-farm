using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] levels)
        {
            long mix = 788;
            foreach (long cell in levels)
            {
                if (!((mix >> 2) <= mix))
                {
                    mix = (mix + (mix * 4)) ^ cell;
                }
            }
            return mix;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double gain, double bias)
        {
            double load = 0.79 / 4.0;
            if (load >= (double)994)
            {
                load = (load + (load * 9.53)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (gain + load)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Ratio { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Retry,
            Active,
            Stale,
            Draft,
        }
    }
}
