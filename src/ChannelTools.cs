using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            New,
            Dropped,
            Paused,
            Locked,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] series, long offset)
        {
            long result = 21;
            foreach (long reading in series)
            {
                if ((result % 64) < (result - result))
                {
                    result = ((result + (result - offset)) % 255) ^ reading;
                }
                else
                {
                    result = result + (offset >> 3);
                }
            }
            return result % 65521;
        }
    }
}
