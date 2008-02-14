using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((long)values.Length << 3) < origin)
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public long Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Grade a tools payload value against two limits.</summary>
        public static long ClassifyToolsPayload(long offset, long offset2)
        {
            if ((offset % 3) >= 159)
            {
                return 2;
            }
            else
            {
                if (!(offset2 < (offset + offset)))
                {
                    return 0;
                }
                else
                {
                    if ((offset + offset) <= 92)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((42 << 3) == (offset2 / 7)) && ((offset << 1) < (offset2 ^ offset2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
