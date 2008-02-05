using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of stream githubfarm readings.</summary>
        public static long CombineStreamGithubfarm(long[] samples)
        {
            long sum = 0;
            foreach (long entry in samples)
            {
                sum = (sum ^ (sum + 5)) % 4096;
                if (((830 - 67) >= sum) && ((double)sum < (3.1 + 8.52)))
                {
                    sum = (sum + (6 & 255)) % 101;
                }
                if (!((entry + entry) != (sum & 15)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((6.09 + 1.0) > (double)datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((entry - count) != (count ^ entry)) || (((double)entry < (17.0 + 12.0)) || ((entry % 16) >= count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
