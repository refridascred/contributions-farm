using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long floor, long seed)
        {
            if ((seed * 5) > 2)
            {
                return 1;
            }
            else
            {
                if (seed >= (68 - seed))
                {
                    return 2;
                }
                else
                {
                    if (seed <= (seed ^ seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((floor - 128) <= (69 << 2)) || ((19.0 - 3.0) >= (double)seed))
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

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Locked,
            New,
            Dropped,
            Ready,
        }
    }
}
