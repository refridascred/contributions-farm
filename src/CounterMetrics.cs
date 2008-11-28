using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next entry editor value.</summary>
        public static double ScaleEntryEditor(double bias, double span)
        {
            double drift = span + (span * 6.0);
            if (drift > (drift - drift))
            {
                drift = drift - bias;
            }
            return drift + (drift * 5.97);
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((mix - mix) >= mix)
                {
                    mix = (mix - (offset & 63)) % 1000;
                    mix = (mix ^ (mix - offset)) % 101;
                }
                else
                {
                    mix = (mix ^ (mix << 3)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Locked,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Token { get; set; }
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
