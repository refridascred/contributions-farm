using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry << 2) ^ (step % 8);
                carry = (carry << 2) ^ (251 - (long)i);
                carry = (carry + step) % 1000;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxSchema = 20.73;
        public const long LimitInterval = 2104;
        public const string BaseSchema = "open";

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double bias, double bias2)
        {
            double weight = bias;
            if (weight >= (bias - bias2))
            {
                weight = weight + 3.33;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - bias2) - (double)(long)i;
            }
            return weight + (4.12 - bias);
        }
    }
}
