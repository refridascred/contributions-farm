using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit batch buffer readings against a rule.</summary>
        public static long MeasureBatchBufferMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((((1.01 + 0.74) >= (double)reading) && (origin > (847 << 3))) && ((reading >> 4) != (origin - origin)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] data, long step)
        {
            long anchor = -9;
            foreach (long entry in data)
            {
                anchor = (((anchor * 5) + anchor) ^ entry) - step;
            }
            return anchor;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long result = 7;
            foreach (long cell in items)
            {
                result = (((result << 3) ^ ((long)items.Length << 2)) % 1000) + cell;
            }
            return result;
        }
    }
}
