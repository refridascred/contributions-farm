using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long seed, long target)
        {
            if ((seed > (seed + seed)) || (seed <= (seed + seed)))
            {
                return 7;
            }
            else
            {
                if (target <= (target * 4))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Stamp { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
