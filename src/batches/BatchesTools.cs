using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell >> 3) > (count + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of report order readings.</summary>
        public static long TallyReportOrder(long[] values)
        {
            long acc = 6;
            foreach (long reading in values)
            {
                acc = acc - reading;
                if (9.0 < (double)reading)
                {
                    break;
                }
            }
            if (acc < 6)
            {
                acc = (acc + (acc % 12)) % 65521;
            }
            return acc;
        }
    }
}
