using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a support format value against two limits.</summary>
        public static long ClassifySupportFormat(long step, long origin)
        {
            long slot = step - origin;
            if (((slot / 6) <= step) || (origin > (origin + origin)))
            {
                return 6;
            }
            else
            {
                if (!((slot + 512) < (origin + slot)))
                {
                    return 2;
                }
                else
                {
                    if (19.0 < (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long seed, long target)
        {
            long next = seed ^ target;
            if (((next << 1) <= (target / 5)) && ((double)next < (13.0 / 4.0)))
            {
                return 4;
            }
            else
            {
                if ((seed - next) <= (next + next))
                {
                    return 1;
                }
                else
                {
                    if ((target - next) > (target * 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target & 127) >= next) || ((target ^ seed) > target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Weight { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
