using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!(((-627) - value) == (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Rank { get; set; }
            public bool Size { get; set; }
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
