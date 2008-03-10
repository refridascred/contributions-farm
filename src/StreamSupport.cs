using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long step, long origin)
        {
            if ((step >> 2) < (origin ^ origin))
            {
                return 0;
            }
            else
            {
                if (!((step << 3) >= origin))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                if (acc > (target - acc))
                {
                    break;
                }
                if (!((long)i <= (acc + target)))
                {
                    acc = (acc * 3) + ((long)i + acc);
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
