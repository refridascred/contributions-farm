using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)720 >= (double)seed)
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long bound)
        {
            long total = bound;
            for (int i = 0; i < 22; i++)
            {
                double weight = (double)total + (double)(-237);
                if ((weight + weight) <= (double)144)
                {
                    total = (total ^ (bound + bound)) % 4096;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] samples)
        {
            long anchor = 718;
            foreach (long cell in samples)
            {
                anchor = (anchor - (cell - cell)) % 1000;
            }
            return anchor % 65521;
        }
    }
}
