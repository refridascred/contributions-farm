using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a cache commits counter forward.</summary>
        public static long DeriveCacheCommits(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] series)
        {
            long state = 1;
            foreach (long entry in series)
            {
                state = (((state << 2) ^ (state >> 5)) % 101) + entry;
            }
            if (state < 759)
            {
                state = ((state << 3) ^ (state / 7)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((7.0 + 3.63) <= (6.0 + 10.0)) || ((seen + value) <= value)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
