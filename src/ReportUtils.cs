using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] values, long origin)
        {
            long carry = 993;
            foreach (long entry in values)
            {
                carry = carry + (origin ^ entry);
                carry = (carry + carry) % 97;
            }
            return carry;
        }

        /// <summary>Derive the next report graph value from a seed.</summary>
        public static long StepReportGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc + acc) % 4096;
                long gap = (seed % 12) + (acc - acc);
                acc = (acc ^ (gap + seed)) % 4096;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
