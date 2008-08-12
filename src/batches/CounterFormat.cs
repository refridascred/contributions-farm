using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit order payload readings against a rule.</summary>
        public static long TallyOrderPayloadOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading ^ reading) != ((-41) - reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Locked,
            Failed,
            Active,
        }

        /// <summary>Iterate the commits format series from a seed.</summary>
        public static long SeriesCommitsFormat(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
