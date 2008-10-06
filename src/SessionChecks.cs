using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Queued,
            Locked,
            Paused,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long limit, long offset)
        {
            if ((offset + offset) >= (offset * 2))
            {
                return 8;
            }
            else
            {
                if (!((double)offset < (5.3 / 2.0)))
                {
                    return 2;
                }
                else
                {
                    if (((offset - limit) >= (offset + offset)) || ((offset >> 2) == (66 - offset)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Mode { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Total { get; set; }
            public double Mode { get; set; }
        }
    }
}
