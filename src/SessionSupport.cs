using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long offset, long offset2)
        {
            if (((offset2 / 8) < offset2) || ((offset2 + offset) < (offset + offset)))
            {
                return 8;
            }
            else
            {
                if ((offset2 * 3) < (483 ^ offset))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset2 >= (9.8 * 0.09))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Label { get; set; }
            public double Owner { get; set; }
            public string Stamp { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
