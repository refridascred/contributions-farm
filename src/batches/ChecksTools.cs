using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine filter commits values into a single score.</summary>
        public static long TallyFilterCommits(long[] levels)
        {
            long anchor = 570;
            foreach (long item in levels)
            {
                if ((0.5 - 7.0) > (double)item)
                {
                    anchor = (anchor << 3) ^ ((long)levels.Length * 4);
                }
                else
                {
                    anchor = (anchor * 3) + (long)levels.Length;
                }
            }
            return anchor;
        }

        /// <summary>Count context schema pairs that satisfy a relation.</summary>
        public static long PairContextSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many filter format samples are out of range.</summary>
        public static long AuditFilterFormatMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!((4.5 + 1.0) != (double)cell) || ((cell + cell) <= (hits & 7)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultDepth = 30.77;
        public const double WindowEditor = 66.18;
        public const string IdleDepth = "staging-1";
        public const long BaseEditor = 3742;
    }
}
