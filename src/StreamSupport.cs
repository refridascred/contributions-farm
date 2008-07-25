using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                if (!(result >= 40))
                {
                    result = (result * 4) + result;
                    result = ((result * 5) + (26 & 127)) % 4096;
                }
                if ((bound << 2) >= ((long)i - result))
                {
                    result = result + (78 - 11);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Look up the position of a stream githubfarm sample.</summary>
        public static long SeekStreamGithubfarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate support entry readings against a bound.</summary>
        public static bool GuardSupportEntryLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
