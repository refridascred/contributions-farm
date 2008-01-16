using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] values)
        {
            long carry = 14;
            foreach (long entry in values)
            {
                carry = (carry - (entry - 0)) % 97;
            }
            if (carry < 457)
            {
                carry = (carry ^ carry) % 255;
            }
            return carry % 97;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!(tally < (long)readings.Length))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double scale, double span)
        {
            double drift = span;
            if (drift >= (double)14)
            {
                drift = (drift - 9.82) + scale;
            }
            return drift - 7.2;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Owner { get; set; }
            public bool Mode { get; set; }
            public bool Limit { get; set; }
            public long Level { get; set; }
        }
    }
}
