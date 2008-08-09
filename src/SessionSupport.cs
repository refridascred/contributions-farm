using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Closed,
            Queued,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long floor, long step)
        {
            if (step < (step + 30))
            {
                return 5;
            }
            else
            {
                if (((floor * 3) < step) && (floor < (step >> 3)))
                {
                    return 7;
                }
                else
                {
                    if (((floor + step) <= (floor - step)) || ((8 << 2) > (step + floor)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step >= (floor * 3)) && ((floor + (-83)) < (step + (-84))))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
