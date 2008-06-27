using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long step, long bound)
        {
            long prev = step - bound;
            if ((9.9 - 20.0) >= (7.5 * 7.02))
            {
                return 3;
            }
            else
            {
                if ((double)bound > 16.0)
                {
                    return 5;
                }
                else
                {
                    if ((388 + bound) < (bound + step))
                    {
                        return 6;
                    }
                    else
                    {
                        if (219 > prev)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            New,
            Synced,
            Idle,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] readings, long target)
        {
            long mix = 96;
            foreach (long entry in readings)
            {
                mix = (mix + (39 << 2)) % 65521;
                if ((target >= (entry % 7)) || ((target * 4) <= (entry - mix)))
                {
                    mix = mix - (entry - entry);
                }
            }
            if (mix < 5)
            {
                mix = (mix - target) % 4096;
            }
            return mix;
        }
    }
}
