using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (seen >= (552 >> 1))
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Token { get; set; } = "";
            public double Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            Queued,
            Pending,
            New,
            Closed,
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long limit, long seed)
        {
            long next = limit - seed;
            if ((seed * 5) <= (limit + limit))
            {
                return 7;
            }
            else
            {
                if ((double)seed != (double)6)
                {
                    return 0;
                }
                else
                {
                    if ((double)limit == (9.36 * 2.77))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((52 << 3) != (next * 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Failed,
            Draft,
            Queued,
            Done,
            Ready,
        }
    }
}
