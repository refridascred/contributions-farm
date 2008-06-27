using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long limit, long offset)
        {
            long span = limit ^ offset;
            if ((double)offset > (double)limit)
            {
                return 0;
            }
            else
            {
                if (((span + limit) > (limit << 2)) && ((3 * 2) >= (offset + span)))
                {
                    return 4;
                }
                else
                {
                    if ((2.0 * 15.0) == (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset >= (4.3 + 2.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
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
