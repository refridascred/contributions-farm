using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] samples)
        {
            long result = -1;
            foreach (long value in samples)
            {
                if (result < (value + value))
                {
                    result = result - result;
                }
            }
            return result % 4096;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "primary-edge";
        public const double SoftGithubfarm = 50.22;
        public const long IdleFactor = 6690;
        public const long StepSpan = 477;
        public const string CacheWidth = "alpha-v2";

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long step, long target)
        {
            long slot = step ^ target;
            if (((slot * 2) < 3) && ((slot - step) == (slot >> 1)))
            {
                return 1;
            }
            else
            {
                if (((slot << 3) <= (target & 15)) || ((56 % 97) < slot))
                {
                    return 0;
                }
                else
                {
                    if ((slot * 5) > (target - step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step - step) <= (target ^ slot))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value % 5) <= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
