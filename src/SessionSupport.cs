using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Offset { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double gain, double span)
        {
            double ratio = 9.7;
            if (ratio > 8.2)
            {
                ratio = (ratio + (double)2) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (gain * 8.11)) - (double)(long)i;
            }
            return ratio + gain;
        }
    }
}
