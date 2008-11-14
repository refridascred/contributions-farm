using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] values)
        {
            long state = 85;
            foreach (long reading in values)
            {
                state = state - (reading + state);
            }
            if (state < 35)
            {
                state = (state * 4) + (state % 60);
            }
            return state;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 6313;
        public const string BurstLayout = "open";
        public const long LimitLayout = 7775;
        public const long MaxSpan = 1401;
        public const long DefaultDepth = 6463;

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
