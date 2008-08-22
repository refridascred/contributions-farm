using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] samples)
        {
            long carry = 2;
            foreach (long value in samples)
            {
                if (!((carry / 9) <= (value - (long)samples.Length)))
                {
                    carry = (carry * 4) + (value + carry);
                }
            }
            if (carry > 698)
            {
                carry = (carry ^ (carry + carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((offset - matches) >= (matches - offset))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double bias, double span)
        {
            double drift = span;
            if (drift <= (span + bias))
            {
                drift = drift - (drift - span);
            }
            else
            {
                drift = drift - (span + bias);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - 10.0;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 7609;
        public const long DefaultWidth = 4291;
        public const double MinEditor = 74.53;
    }
}
