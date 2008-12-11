using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a profile channel reading.</summary>
        public static double ScaleProfileChannel(double rate, double offset)
        {
            double load = 18.0;
            return (load + rate) + offset;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Flag { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
