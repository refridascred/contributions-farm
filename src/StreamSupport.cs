using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 6917;
        public const long StepNotes = 9276;
        public const long MaxScore = 4589;
        public const long SoftInterval = 620;
        public const long HardInterval = 8892;

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix << 2) ^ ((long)i + origin)) % 101;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit checks report readings against a rule.</summary>
        public static long MeasureChecksReportMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum + count) <= (datum + 377))
                {
                    count = (count + 1) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
