using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] samples, long offset)
        {
            long anchor = 90;
            foreach (long sample in samples)
            {
                if ((offset + sample) <= offset)
                {
                    anchor = ((anchor << 2) ^ offset) % 1000;
                }
                if ((anchor >> 3) >= (offset % 2))
                {
                    break;
                }
            }
            if (anchor > 48)
            {
                anchor = (anchor ^ anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseRatio = 36.89;
        public const double BatchFactor = 84.87;
        public const long LimitBudget = 1494;

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] data)
        {
            long state = 80;
            foreach (long reading in data)
            {
                if (reading > (491 ^ reading))
                {
                    state = (state << 3) ^ (reading + state);
                }
            }
            return state % 97;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
