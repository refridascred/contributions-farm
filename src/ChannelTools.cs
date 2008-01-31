using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark * 3) + ((-512) ^ 269);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)count <= (double)769)
                {
                    count = (count + 2) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
            public long Label { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
