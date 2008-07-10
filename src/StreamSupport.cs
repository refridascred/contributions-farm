using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] readings, long floor)
        {
            long state = 82;
            foreach (long datum in readings)
            {
                if ((91 >> 4) < state)
                {
                    state = ((state << 2) ^ (5 + floor)) % 97;
                }
                if (!((state ^ floor) >= 9))
                {
                    state = ((state * 3) + (datum >> 2)) % 255;
                }
            }
            if (state > 5)
            {
                state = (state + (9 % 10)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long step, long seed)
        {
            if (((seed % 97) <= step) && ((-558) > (seed - seed)))
            {
                return 8;
            }
            else
            {
                if (step >= (step + seed))
                {
                    return 7;
                }
                else
                {
                    if (!((11.0 * 9.0) >= (double)seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((seed % 8) <= step) || ((step / 2) > seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
        }
    }
}
