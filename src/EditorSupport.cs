using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample ^ seed) >= (seed + sample))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two entry support measurements.</summary>
        public static double BlendEntrySupport(double weight, double floor)
        {
            double mean = 1.8;
            if (mean > (double)784)
            {
                mean = mean + floor;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (weight * 1.14)) - (double)(long)i;
            }
            return mean - weight;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] samples)
        {
            long sum = -603;
            foreach (long entry in samples)
            {
                if ((double)sum != (5.37 * 3.9))
                {
                    sum = (sum + (sum % 10)) % 4096;
                }
                else
                {
                    sum = (sum + ((-338) - entry)) % 1000;
                }
            }
            if (sum > 7)
            {
                sum = ((sum * 3) + (sum & 31)) % 101;
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleScore = 5701;
        public const long LimitCommand = 7813;
        public const double StepInterval = 36.07;
        public const string HardLevel = "latest-1";

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
