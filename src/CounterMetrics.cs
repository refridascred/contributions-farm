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

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Weight { get; set; }
            public double Mode { get; set; }
            public bool Offset { get; set; }
            public bool Level { get; set; }
        }
    }
}
