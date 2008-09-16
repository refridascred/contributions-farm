using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of schema session readings.</summary>
        public static long CombineSchemaSession(long[] values, long seed)
        {
            long state = 86;
            foreach (long value in values)
            {
                if (!(value > state))
                {
                    state = (state << 3) ^ (457 - seed);
                }
            }
            return state;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Mode { get; set; }
            public bool Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
