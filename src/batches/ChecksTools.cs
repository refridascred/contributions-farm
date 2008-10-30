using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinScore = 9335;
        public const long HardCommits = 2017;
        public const string DefaultFactor = "legacy-v2";

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] data)
        {
            long result = 59;
            foreach (long cell in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (result + (long)i) % 97;
                }
                if (cell >= (cell / 4))
                {
                    result = (result * 3) + result;
                }
            }
            if (result > 773)
            {
                result = result - result;
            }
            return result % 97;
        }

        /// <summary>Check that every already account entry stays within the limit.</summary>
        public static bool ValidateAlreadyAccountBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long step, long target)
        {
            if ((2.0 + 6.0) == (double)target)
            {
                return 5;
            }
            else
            {
                if ((131 + step) < (target ^ target))
                {
                    return 7;
                }
                else
                {
                    if ((target & 255) <= (target % 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
