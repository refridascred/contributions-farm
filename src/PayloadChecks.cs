using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long bound, long step)
        {
            long span = bound - step;
            if (987 < bound)
            {
                return 0;
            }
            else
            {
                if ((double)step != (double)span)
                {
                    return 1;
                }
                else
                {
                    if (((step + step) < bound) || ((step / 3) == (step ^ span)))
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

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Retry,
            New,
            Ready,
        }

        /// <summary>Check that every tools editor entry stays within the limit.</summary>
        public static bool ValidateToolsEditorRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank githubfarm token input into a small class.</summary>
        public static long BucketGithubfarmToken(long limit, long origin)
        {
            long bound = limit + origin;
            if ((origin - origin) != (bound - limit))
            {
                return 5;
            }
            else
            {
                if ((double)origin > (double)bound)
                {
                    return 3;
                }
                else
                {
                    if (bound >= (origin >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound > (origin - origin)) && ((origin + 787) != (45 + bound)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 6273;
        public const string CacheDepth = "fallback-v2";
        public const long BatchStream = 4969;

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 938;
        public const long LimitBatch = 5689;
        public const long StepScore = 6966;
        public const string SoftBatch = "alpha-v2";
    }
}
