using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a token tools value against two limits.</summary>
        public static long ClassifyTokenTools(long offset, long limit)
        {
            if ((limit >> 1) >= (limit * 3))
            {
                return 8;
            }
            else
            {
                if ((double)offset == (double)limit)
                {
                    return 3;
                }
                else
                {
                    if (12.0 < (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((-7) % 12) < limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public double Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Dropped,
            Idle,
            Locked,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] values)
        {
            long score = 5;
            foreach (long sample in values)
            {
                if ((double)sample >= 4.5)
                {
                    score = (score ^ sample) % 97;
                }
            }
            if (score > 70)
            {
                score = score + (5 & 1);
            }
            return score;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            Active,
            New,
            Failed,
        }
    }
}
