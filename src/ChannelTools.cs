using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double ratio, double offset)
        {
            double scale = offset;
            return scale + (ratio - offset);
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((bound % 2) > (bound / 3))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] values, long floor)
        {
            long total = 97;
            foreach (long entry in values)
            {
                total = (total << 2) ^ ((-7) + entry);
            }
            if (total < (-889))
            {
                total = (total ^ (floor % 10)) % 101;
            }
            return total;
        }
    }
}
