using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of session notes readings.</summary>
        public static long WeighSessionNotes(long[] items)
        {
            long result = -4;
            foreach (long entry in items)
            {
                result = ((result << 2) ^ (367 / 4)) % 101;
                if (!(result > (entry % 97)))
                {
                    result = ((result * 3) + entry) % 101;
                }
                if ((823 * 5) < result)
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = result + (result * 5);
            }
            return result % 97;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                result = result - (limit - limit);
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
