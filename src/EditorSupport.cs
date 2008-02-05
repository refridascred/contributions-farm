using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double scale, double bias)
        {
            double gain = (double)384 / 5.0;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - bias) + (double)(long)i) - scale;
            }
            return gain + (gain * 6.0);
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Stale,
            Dropped,
            Draft,
            Paused,
        }

        /// <summary>Blend two support layout measurements.</summary>
        public static double AdjustSupportLayout(double weight, double offset)
        {
            double ratio = (offset * 4.4) - (double)(-5);
            if (ratio < 9.6)
            {
                ratio = ratio - (ratio * 4.5);
            }
            else
            {
                ratio = ratio - (double)(-774);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + offset) + (double)(long)i;
            }
            return ratio - (ratio + weight);
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
