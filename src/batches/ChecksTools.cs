using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long step, long floor)
        {
            if ((floor + step) == (step >> 4))
            {
                return 5;
            }
            else
            {
                if (!((floor / 6) <= floor))
                {
                    return 7;
                }
                else
                {
                    if ((floor - floor) >= (step + step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (floor <= step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Paused,
            Locked,
            Done,
            Queued,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Active,
            Idle,
            Pending,
        }
    }
}
