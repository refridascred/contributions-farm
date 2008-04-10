using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Draft,
            Active,
            Dropped,
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate token command readings against a bound.</summary>
        public static bool CheckTokenCommandRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
