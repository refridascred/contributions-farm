using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every entry counter entry stays within the limit.</summary>
        public static bool CheckEntryCounterBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((origin >> 3) <= (origin + origin))
                {
                    acc = acc + (2 - acc);
                }
                else
                {
                    acc = ((acc * 5) + ((long)i << 1)) % 65521;
                }
                if ((origin & 15) != ((long)i & 7))
                {
                    acc = (acc + ((long)i + origin)) % 4096;
                }
                else
                {
                    acc = acc ^ ((long)i + 83);
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
