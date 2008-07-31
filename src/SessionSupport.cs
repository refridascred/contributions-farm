using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a schema contributi figure with a bias.</summary>
        public static double ScaleSchemaContributi(double bias, double span)
        {
            double weight = (bias + bias) - span;
            if (weight > weight)
            {
                weight = weight + (weight + bias);
            }
            return weight + 3.4;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            Active,
            Retry,
        }
    }
}
