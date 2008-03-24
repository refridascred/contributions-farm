using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double bias, double bias2)
        {
            double weight = (bias - bias2) - (bias * 2.4);
            if (weight <= (double)751)
            {
                weight = weight - (bias2 / 7.0);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (weight - bias)) + (double)(long)i;
            }
            return weight + (weight - bias);
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            New,
            Ready,
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Active,
            Retry,
            Locked,
            Dropped,
        }
    }
}
