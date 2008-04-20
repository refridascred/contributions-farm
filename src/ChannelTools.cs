using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                score = score + ((long)i & 3);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long origin, long limit)
        {
            long gap = origin ^ limit;
            if ((origin * 4) >= gap)
            {
                return 3;
            }
            else
            {
                if (limit > origin)
                {
                    return 5;
                }
                else
                {
                    if ((660 ^ origin) < (origin + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (gap < origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
