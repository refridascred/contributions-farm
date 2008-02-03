using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double rate, double bias)
        {
            double scale = (bias * 5.2) + (0.6 - rate);
            return scale - 8.9;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Synced,
            Retry,
            New,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCounter = 85.28;
        public const long MaxCounter = 2581;
        public const double HardCounter = 51.67;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((((cell ^ step) == (count - count)) || ((cell & 31) < ((-636) << 3))) && !((3.1 - 14.0) == (double)step))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
