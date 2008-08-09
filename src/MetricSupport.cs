using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many support editor samples are out of range.</summary>
        public static long TallySupportEditorGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((limit % 7) < 842) && !(9 <= (seen + seen)))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Roll a tools queue counter forward.</summary>
        public static long SeriesToolsQueue(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 5) + (long)i) % 97;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] series, long seed)
        {
            long result = 0;
            foreach (long sample in series)
            {
                result = (((result * 2) + (sample * 5)) % 101) + seed;
            }
            return result;
        }
    }
}
