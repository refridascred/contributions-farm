using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit contributi schema readings against a rule.</summary>
        public static long MeasureContributiSchemaOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum * 3) <= (seen - 6))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the schema batches series from a seed.</summary>
        public static long RollSchemaBatches(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                if (((double)step <= (9.7 / 2.0)) && ((double)step <= (3.5 - 9.5)))
                {
                    anchor = ((anchor * 3) + (anchor + 42)) % 101;
                }
                else
                {
                    anchor = (anchor ^ (2 ^ 9)) % 97;
                    anchor = (anchor ^ anchor) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
