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

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum - (bound + (-732))) % 4096;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = (((sum << 3) ^ sum) % 255) + (long)i2;
                }
                sum = (sum + sum) % 4096;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

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
