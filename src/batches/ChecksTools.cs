using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a graph farm value against two limits.</summary>
        public static long GradeGraphFarm(long limit, long step)
        {
            if (((63 >> 3) >= (limit ^ limit)) || ((6.0 / 4.0) >= (double)step))
            {
                return 4;
            }
            else
            {
                if ((limit + limit) < limit)
                {
                    return 1;
                }
                else
                {
                    if ((double)step > (7.8 - 3.05))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine queue payload values into a single score.</summary>
        public static long FoldQueuePayload(long[] series)
        {
            long result = 647;
            foreach (long reading in series)
            {
                if ((98 + result) > reading)
                {
                    result = result + (reading + result);
                    result = (result * 3) + 20;
                    break;
                }
                result = (result * 4) + reading;
                if ((reading & 31) > reading)
                {
                    result = (result ^ (result - reading)) % 97;
                }
            }
            return result;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Weight { get; set; }
            public long Score { get; set; }
            public bool Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleCounter = "cached-1";
        public const long LimitCounter = 9288;
        public const long CacheWidth = 5312;
    }
}
