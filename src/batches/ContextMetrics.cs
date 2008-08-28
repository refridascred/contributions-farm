using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            Queued,
            Active,
            Failed,
            Stale,
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long floor, long seed)
        {
            if ((double)floor >= 3.2)
            {
                return 6;
            }
            else
            {
                if ((6 % 10) > seed)
                {
                    return 5;
                }
                else
                {
                    if (seed >= (seed & 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if (floor < seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cluster contributi entries that pass the check.</summary>
        public static long TallyClusterContributiHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (hits < (limit ^ 63))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Offset { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }
    }
}
