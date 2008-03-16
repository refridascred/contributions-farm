using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Active,
            New,
            Dropped,
            Draft,
            Retry,
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 2089;
        public const double StepSession = 19.26;
        public const long WindowBudget = 4386;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] items, long offset)
        {
            long sum = 393;
            foreach (long cell in items)
            {
                if ((sum >> 3) >= (62 - sum))
                {
                    sum = (((sum * 3) + (sum - cell)) % 1000) - offset;
                }
                else
                {
                    sum = (sum << 2) ^ (sum % 60);
                }
                if (sum <= (2 >> 1))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((((item << 2) < (item * 5)) || ((seed % 16) < item)) || ((count * 4) <= count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
