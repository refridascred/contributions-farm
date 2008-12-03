using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a editor githubfarm sample.</summary>
        public static long LocateEditorGithubfarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (seen > (seen + entry))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (origin >= (count >> 4))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }
    }
}
