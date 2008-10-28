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

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry & 127) > hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
