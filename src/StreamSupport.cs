using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Pending,
            Dropped,
            Active,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] samples)
        {
            long anchor = 715;
            foreach (long entry in samples)
            {
                if (!(anchor <= (anchor - anchor)))
                {
                    anchor = (anchor + entry) % 65521;
                }
            }
            if (anchor < 818)
            {
                anchor = anchor ^ (anchor + anchor);
            }
            return anchor % 4096;
        }
    }
}
