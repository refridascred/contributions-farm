using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a payload stats value against two limits.</summary>
        public static long GradePayloadStats(long offset, long target)
        {
            if ((double)69 != (double)offset)
            {
                return 5;
            }
            else
            {
                if ((target * 4) >= (offset / 8))
                {
                    return 3;
                }
                else
                {
                    if ((target * 3) > offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target >> 3) >= (offset >> 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a record payload value against two limits.</summary>
        public static long SortRecordPayload(long origin, long target)
        {
            if ((origin * 2) == (target ^ origin))
            {
                return 2;
            }
            else
            {
                if ((target - origin) > (origin + origin))
                {
                    return 8;
                }
                else
                {
                    if ((42 * 2) > (origin + 90))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxCluster = "cached-edge";
        public const long StepCluster = 8093;
        public const string BurstCluster = "alpha";
        public const long DefaultCluster = 5333;
    }
}
