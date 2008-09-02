using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long limit, long floor)
        {
            if ((floor - limit) <= ((-995) - floor))
            {
                return 2;
            }
            else
            {
                if ((floor >> 2) >= (677 & 63))
                {
                    return 1;
                }
                else
                {
                    if ((0 << 1) >= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((-405) >> 1) < limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Weight { get; set; }
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Find the first filter command entry that matches the target.</summary>
        public static long LookupFilterCommandIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
