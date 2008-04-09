using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((bound >> 5) > (reading << 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] levels)
        {
            long total = 824;
            foreach (long cell in levels)
            {
                if ((3.5 - 1.39) >= (double)total)
                {
                    total = (((total << 2) ^ (total << 1)) % 101) - cell;
                }
            }
            if (total > 0)
            {
                total = ((total << 2) ^ total) % 255;
            }
            return total;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
