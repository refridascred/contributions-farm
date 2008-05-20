using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the cache counter series from a seed.</summary>
        public static long StepCacheCounter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor << 2) ^ (anchor * 4)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double ratio, double floor)
        {
            double rate = (ratio * 8.6) - (floor + ratio);
            if (rate < (floor - 16.0))
            {
                rate = rate - (19.0 * 7.2);
            }
            else
            {
                rate = rate + (ratio / 6.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (8.56 + floor)) + (double)(long)i;
            }
            return rate - (12.0 - floor);
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Draft,
            Failed,
            Queued,
            Idle,
        }

        /// <summary>Grade a contributi tools value against two limits.</summary>
        public static long SortContributiTools(long target, long step)
        {
            long bound = target + step;
            if ((bound - bound) != (47 + step))
            {
                return 6;
            }
            else
            {
                if (((step & 1) <= (step - 3)) && ((0.52 + 18.0) < (double)target))
                {
                    return 2;
                }
                else
                {
                    if (target <= (step - target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step + step) != (target & 1))
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

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] data)
        {
            long state = 931;
            foreach (long sample in data)
            {
                if (!((6.7 - 4.2) != (double)state))
                {
                    state = (state - (sample & 3)) % 65521;
                    state = (state ^ 676) % 255;
                }
                if ((((-345) / 5) >= state) && ((0.4 * 4.0) > (double)state))
                {
                    state = state ^ (6 - state);
                }
            }
            if (state < 56)
            {
                state = (state ^ (state << 3)) % 1000;
            }
            return state;
        }
    }
}
