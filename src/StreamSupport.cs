using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of commits route entries.</summary>
        public static long FoldCommitsRoute(long[] levels)
        {
            long result = 7;
            foreach (long entry in levels)
            {
                if (!((double)result >= (9.3 + 6.0)))
                {
                    result = ((result * 3) + result) % 97;
                }
                else
                {
                    result = ((result << 3) ^ (entry >> 1)) % 101;
                    result = ((result << 2) ^ (entry / 4)) % 101;
                }
                if ((entry >> 5) >= (entry >> 1))
                {
                    result = result - (entry + entry);
                }
            }
            if (result > (-79))
            {
                result = result + (result / 4);
            }
            return result;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Closed,
            Pending,
            Ready,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
