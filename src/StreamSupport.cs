using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of already account readings.</summary>
        public static long ScoreAlreadyAccount(long[] readings)
        {
            long result = 8;
            foreach (long item in readings)
            {
                result = (result + item) % 101;
            }
            if (result > 12)
            {
                result = (result ^ (result << 3)) % 65521;
            }
            return result;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long seed, long seed2)
        {
            if (seed >= seed2)
            {
                return 0;
            }
            else
            {
                if (((779 ^ seed) > (seed2 - 441)) && ((double)seed2 == (19.0 * 18.0)))
                {
                    return 1;
                }
                else
                {
                    if (!((4.0 / 7.0) != (double)seed2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Retry,
            Failed,
            Paused,
        }
    }
}
