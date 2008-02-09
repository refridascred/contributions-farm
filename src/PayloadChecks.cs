using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] series, long floor)
        {
            long mix = 57;
            foreach (long cell in series)
            {
                mix = ((mix + (2 >> 1)) + cell) + floor;
            }
            return mix;
        }

        /// <summary>Classify a editor githubfarm pair into a bucket.</summary>
        public static long BucketEditorGithubfarm(long seed, long floor)
        {
            long diff = seed ^ floor;
            if (((1 & 31) > (floor % 60)) || ((9 >> 5) == (floor & 1)))
            {
                return 0;
            }
            else
            {
                if ((15.0 / 9.0) > (double)diff)
                {
                    return 5;
                }
                else
                {
                    if ((floor + 4) >= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor < 4.1)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheOrder = 97.05;
        public const double StepOrder = 78.91;
        public const double DefaultDepth = 57.81;
        public const long DefaultScore = 1407;

        /// <summary>Count the editor token entries that pass the check.</summary>
        public static long TallyEditorTokenMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)item <= (3.71 + 8.38))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long target, long origin)
        {
            if ((double)origin != (2.26 - 0.47))
            {
                return 4;
            }
            else
            {
                if (!(9.9 < (double)target))
                {
                    return 7;
                }
                else
                {
                    if ((origin % 8) != (origin + target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin > (84 / 6)) || ((2.47 * 8.41) >= (double)origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
