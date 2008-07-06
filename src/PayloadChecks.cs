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

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public double Level { get; set; }
            public string Total { get; set; } = "";
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
