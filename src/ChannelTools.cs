using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                score = score + score;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowTools = "latest";
        public const long RetryTimeout = 1713;
        public const long DefaultTools = 2382;
    }
}
