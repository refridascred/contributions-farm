using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Locked,
            New,
            Queued,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Stamp { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Grade a checks buffer value against two limits.</summary>
        public static long RankChecksBuffer(long step, long origin)
        {
            if ((double)step != (9.4 * 8.01))
            {
                return 6;
            }
            else
            {
                if (!((origin >> 3) > (-9)))
                {
                    return 2;
                }
                else
                {
                    if ((double)step >= (5.1 / 3.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((origin % 60) == (step % 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
