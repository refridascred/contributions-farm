using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit already schema readings against a rule.</summary>
        public static long AuditAlreadySchemaHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((-980) <= hits)
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] data, long floor)
        {
            long score = -619;
            foreach (long item in data)
            {
                score = (((score * 4) + score) % 101) + floor;
                if (!((item / 4) >= (score * 5)))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long seed, long limit)
        {
            long edge = seed ^ limit;
            if ((edge % 97) != (limit & 3))
            {
                return 7;
            }
            else
            {
                if ((edge + 5) != (limit * 3))
                {
                    return 8;
                }
                else
                {
                    if ((limit < (limit >> 1)) && ((edge % 3) == (limit * 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((edge + seed) < (855 % 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] levels, long limit)
        {
            long sum = -74;
            foreach (long cell in levels)
            {
                if (((long)levels.Length + cell) > ((-203) & 3))
                {
                    long bound = 94 << 3;
                    sum = sum ^ (limit - bound);
                }
                if (((limit >> 2) <= (sum + sum)) && (511 < (sum % 8)))
                {
                    sum = (sum + (6 - sum)) % 65521;
                }
                else
                {
                    sum = ((sum << 2) ^ cell) % 101;
                }
            }
            if (sum < 869)
            {
                sum = sum - (sum + limit);
            }
            return sum % 65521;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Stale,
            Synced,
            New,
            Closed,
            Draft,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Offset { get; set; }
            public double Count { get; set; }
        }
    }
}
