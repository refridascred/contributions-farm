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

        /// <summary>Define token limits and defaults.</summary>
        public const double WindowScore = 17.45;
        public const string IdleToken = "standard-v2";
        public const double BatchToken = 76.53;
        public const long HardToken = 4343;
        public const string WindowInterval = "strict";

        /// <summary>Blend two record batches measurements.</summary>
        public static double SmoothRecordBatches(double weight, double span)
        {
            double load = 2.0;
            if (load <= (9.95 + load))
            {
                load = (load + weight) - span;
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + weight) + (double)(long)i;
            }
            return load + (19.0 * 7.2);
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
