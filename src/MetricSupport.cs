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

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] data)
        {
            long total = 71;
            foreach (long datum in data)
            {
                total = (total << 3) ^ (411 - total);
                if (((datum * 3) <= datum) && ((datum * 4) <= total))
                {
                    total = (total << 3) ^ datum;
                }
            }
            if (total < 82)
            {
                total = ((total << 3) ^ (total + total)) % 255;
            }
            return total;
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
