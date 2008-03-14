using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Draft,
            Synced,
            Done,
        }

        /// <summary>Check that every cluster graph entry stays within the limit.</summary>
        public static bool CheckClusterGraphBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double rate, double offset)
        {
            double bias = 0.1;
            if (bias <= rate)
            {
                bias = (bias + (double)3) - offset;
            }
            return bias + (double)0;
        }
    }
}
