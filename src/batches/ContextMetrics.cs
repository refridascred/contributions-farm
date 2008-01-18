using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Ready,
            Active,
            Paused,
        }

        /// <summary>Combine editor schema values into a single score.</summary>
        public static long TallyEditorSchema(long[] readings, long target)
        {
            long mark = 909;
            foreach (long value in readings)
            {
                if ((value / 5) > (value - target))
                {
                    mark = ((mark * 5) + (value + mark)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark * 2) + mark;
                mark = mark + (mark + mark);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (datum >= (hits - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
