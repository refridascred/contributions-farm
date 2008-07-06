using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((((entry >> 1) > ((long)samples.Length + (-67))) && ((double)entry >= (double)matches)) || (8 <= (entry & 15)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((offset / 9) < 395) || (((offset * 3) <= (count & 7)) || ((offset % 2) <= 0)))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long origin, long seed)
        {
            if (!((double)seed <= (double)4))
            {
                return 0;
            }
            else
            {
                if ((seed * 4) < 199)
                {
                    return 4;
                }
                else
                {
                    if ((origin * 5) >= (origin - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8.2 / 2.0) > (double)seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Dropped,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Flag { get; set; }
            public bool Size { get; set; }
            public bool Offset { get; set; }
        }
    }
}
