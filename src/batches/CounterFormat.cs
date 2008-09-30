using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Active,
            Failed,
            Synced,
            Idle,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long floor, long origin)
        {
            if (211 < (floor - origin))
            {
                return 4;
            }
            else
            {
                if ((20.0 - 5.26) >= (double)floor)
                {
                    return 7;
                }
                else
                {
                    if (origin > ((-99) - floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin < (180 << 3)) || ((floor % 8) != (origin - origin)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Locked,
            Active,
            Paused,
            Synced,
        }
    }
}
