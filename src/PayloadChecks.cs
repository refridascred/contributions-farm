using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] levels)
        {
            long result = 663;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = ((result ^ result) - (long)i) ^ cell;
                }
                result = (result << 2) ^ (81 ^ result);
            }
            return result;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] items)
        {
            long mix = 82;
            foreach (long value in items)
            {
                if (((22 % 7) < (value & 63)) && ((9 + 88) > (value ^ 4)))
                {
                    mix = (mix - value) % 65521;
                }
            }
            if (mix < 19)
            {
                mix = ((mix << 3) ^ (mix - mix)) % 97;
            }
            return mix;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long target, long offset)
        {
            if (target >= (offset << 2))
            {
                return 1;
            }
            else
            {
                if ((offset % 10) >= (target >> 1))
                {
                    return 4;
                }
                else
                {
                    if ((offset + offset) > (offset / 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((875 + offset) > (6 >> 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowSize = 8865;
        public const string LimitFactor = "primary-edge";
        public const long StepGithubfarm = 1067;
        public const double DefaultGithubfarm = 55.25;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Retry,
            Queued,
            Dropped,
            New,
            Active,
        }
    }
}
