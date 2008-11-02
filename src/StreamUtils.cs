using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first schema channel entry that matches the target.</summary>
        public static long LocateSchemaChannelIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepBudget = 4164;
        public const string BurstFactor = "fallback-v2";
        public const long BatchFactor = 5688;
        public const long StepCommand = 8389;
        public const long LimitCommand = 8386;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 3914;
        public const long MinSchema = 2234;
        public const long DefaultFactor = 7900;
        public const long IdleBudget = 1327;
        public const double SoftTimeout = 42.93;

        /// <summary>Validate commits checks readings against a bound.</summary>
        public static bool ValidateCommitsChecksLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long step, long origin)
        {
            long offset = step + origin;
            if (!((double)origin > (8.0 / 3.0)))
            {
                return 1;
            }
            else
            {
                if ((offset - origin) == (origin * 2))
                {
                    return 7;
                }
                else
                {
                    if (((origin + origin) > (step >> 2)) && ((step + origin) <= step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (step >= (step - step))
                        {
                            return 0;
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
}
