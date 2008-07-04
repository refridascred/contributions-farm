using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Blend two filter counter measurements.</summary>
        public static double ProjectFilterCounter(double scale, double offset)
        {
            double load = (7.9 / 9.0) + (offset / 9.0);
            if (load >= offset)
            {
                load = load - (scale / 9.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + offset) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 < rate2)
            {
                rate2 = (rate2 - rate2) - floor;
            }
            return rate2 - (rate + 6.91);
        }
    }
}
