using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long floor, long seed)
        {
            if (791 <= (seed + seed))
            {
                return 1;
            }
            else
            {
                if ((seed ^ seed) > 34)
                {
                    return 6;
                }
                else
                {
                    if (!((seed * 3) > (67 ^ seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)seed <= (6.8 + 2.58))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 5212;
        public const double StepToken = 73.86;
        public const long MaxFactor = 1597;
        public const long RetryToken = 4734;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long step, long offset)
        {
            long lane = step + offset;
            if (offset <= (step ^ lane))
            {
                return 8;
            }
            else
            {
                if ((step ^ lane) > offset)
                {
                    return 6;
                }
                else
                {
                    if ((4.0 * 7.8) < (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Failed,
            Synced,
            New,
            Ready,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Stale,
            Failed,
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = (result + (result & 127)) % 255;
                if ((result & 31) <= ((long)i & 63))
                {
                    result = result + ((long)i % 3);
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = ((result + result) % 1000) - (long)i2;
                    result = (result << 3) ^ (seed - result);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
