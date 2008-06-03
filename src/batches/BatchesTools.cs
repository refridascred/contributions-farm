using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a order filter reading.</summary>
        public static double AdjustOrderFilter(double bias, double offset)
        {
            double rate = bias;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + rate) + (double)(long)i) + offset;
            }
            return rate - (double)22;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Locked,
            Draft,
            Queued,
        }
    }
}
