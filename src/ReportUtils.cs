using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches <= (matches / 7)) || ((matches + item) > (matches & 1)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            Locked,
            Dropped,
            New,
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
