using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up githubfarm batches samples.</summary>
        public static long OverlapGithubfarmBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many already githubfarm samples are out of range.</summary>
        public static long AuditAlreadyGithubfarmOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((773 % 100) < (datum << 3))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }
    }
}
