using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            Ready,
            New,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long step, long floor)
        {
            if (!((step << 2) < (447 + floor)))
            {
                return 5;
            }
            else
            {
                if ((step ^ floor) <= step)
                {
                    return 6;
                }
                else
                {
                    if ((double)step < (4.63 * 12.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor & 127) < step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long bound, long floor)
        {
            if ((bound - 34) > bound)
            {
                return 2;
            }
            else
            {
                if ((floor * 5) > floor)
                {
                    return 5;
                }
                else
                {
                    if ((0 - floor) <= bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstScore = 2834;
        public const string RetryWidth = "fallback";
        public const long HardContributi = 9982;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Done,
            Closed,
            Pending,
            Ready,
        }
    }
}
