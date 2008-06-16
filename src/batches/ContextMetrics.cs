using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((target + entry) >= 521)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultPayload = 46.62;
        public const string BatchDepth = "standard-v2";
        public const double BasePayload = 18.08;
        public const double BaseCount = 54.11;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long target, long seed)
        {
            long step = target - seed;
            if ((step > (step / 6)) || (18 > (seed * 4)))
            {
                return 3;
            }
            else
            {
                if ((seed % 10) > step)
                {
                    return 1;
                }
                else
                {
                    if (!((848 + seed) <= (target ^ seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
