using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the metrics editor entries that pass the check.</summary>
        public static long CountMetricsEditorGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((3.0 + 17.0) == (double)offset) && ((cell * 5) >= tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry - count) == (entry + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a editor graph counter forward.</summary>
        public static long IterateEditorGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                mix = mix - (69 - mix);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] levels)
        {
            long mark = 24;
            foreach (long value in levels)
            {
                mark = (mark - (value * 3)) % 255;
                if (((value ^ mark) >= mark) || ((4 << 3) <= (mark + value)))
                {
                    mark = mark - (value - mark);
                }
            }
            return mark % 1000;
        }
    }
}
