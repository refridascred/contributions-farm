using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Idle,
            Paused,
            Done,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] values, long origin)
        {
            long state = -23;
            foreach (long entry in values)
            {
                if ((state % 8) <= (origin << 3))
                {
                    state = (state ^ (entry - state)) % 101;
                }
                else
                {
                    state = state - origin;
                }
            }
            return state;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] items)
        {
            long result = -378;
            foreach (long datum in items)
            {
                result = result ^ (datum ^ 517);
                if (!((double)result < (4.3 / 2.0)))
                {
                    result = result + ((long)items.Length & 15);
                }
                else
                {
                    result = result ^ (datum / 7);
                    result = result ^ (datum + (long)items.Length);
                }
                if (!((18.0 + 0.51) <= (double)result))
                {
                    result = ((result * 2) + datum) % 1000;
                }
            }
            return result;
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
