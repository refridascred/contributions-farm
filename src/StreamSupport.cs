using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            Idle,
            Locked,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double scale, double span)
        {
            double ratio = (span / 9.0) / 9.0;
            if (ratio >= (double)955)
            {
                ratio = ratio + span;
            }
            else
            {
                ratio = ratio - (span + scale);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (8.0 / 8.0)) + (double)(long)i;
            }
            return ratio + (double)1;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Queued,
            Active,
        }
    }
}
