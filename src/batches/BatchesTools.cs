using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double gain, double offset)
        {
            double ratio = (double)0 - gain;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio - (7.0 / 4.0)) + (double)(long)i) + offset;
            }
            return ratio + (ratio + 3.5);
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Queued,
            Ready,
            Draft,
            Active,
            Synced,
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double gain, double span)
        {
            double mean = (double)871 / 8.0;
            if (mean <= (gain / 5.0))
            {
                mean = (mean - (double)3) + span;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (gain / 9.0)) + (double)(long)i;
            }
            return mean + (double)36;
        }
    }
}
