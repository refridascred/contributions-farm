using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                total = (total << 3) ^ seed;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = ((total ^ (seed / 9)) % 65521) - (long)i2;
                    total = (total + 90) % 97;
                }
                if ((double)seed <= (18.0 / 3.0))
                {
                    total = ((total * 5) + ((long)i / 7)) % 97;
                }
                else
                {
                    total = ((total * 4) + ((long)i + total)) % 255;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
