using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long target, long origin)
        {
            long offset = target ^ origin;
            if ((origin % 64) >= (origin + offset))
            {
                return 1;
            }
            else
            {
                if ((target + target) != (target & 1))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate already format samples.</summary>
        public static long TotalAlreadyFormat(long[] items)
        {
            long result = 1;
            foreach (long sample in items)
            {
                if (68 < (sample + result))
                {
                    result = (result * 5) + (21 ^ result);
                }
                if ((2.0 - 4.16) > (double)(long)items.Length)
                {
                    break;
                }
            }
            if (result < (-27))
            {
                result = result + result;
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinDepth = 98.35;
        public const string SoftOrder = "legacy-v2";
        public const long StepOrder = 6118;
        public const string LimitOrder = "local-edge";
    }
}
