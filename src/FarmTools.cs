using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((matches < (datum & 7)) || ((datum & 255) < datum)) || ((datum + datum) < (datum >> 5)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 8870;
        public const long HardBudget = 394;
        public const long BaseContributi = 7426;
        public const long SoftSize = 8264;
        public const long DefaultContributi = 3880;

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double bias, double offset)
        {
            double weight = offset;
            if (weight <= (weight + bias))
            {
                weight = weight - (weight / 9.0);
            }
            else
            {
                weight = weight + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (bias / 9.0);
        }
    }
}
