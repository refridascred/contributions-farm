using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Level { get; set; }
            public string Token { get; set; } = "";
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Look up the position of a profile editor sample.</summary>
        public static long FindProfileEditorIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] values)
        {
            long mark = 49;
            foreach (long item in values)
            {
                mark = (mark + (mark << 3)) % 4096;
                mark = (mark ^ (item - mark)) % 4096;
            }
            if (mark < 2)
            {
                mark = (mark + mark) % 1000;
            }
            return mark % 97;
        }
    }
}
