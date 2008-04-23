using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long target, long target2)
        {
            long diff = target ^ target2;
            if ((3.9 * 3.0) > (double)target2)
            {
                return 1;
            }
            else
            {
                if ((double)target != (double)target2)
                {
                    return 6;
                }
                else
                {
                    if ((double)diff > (3.7 + 20.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Token { get; set; } = "";
            public double Mode { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
