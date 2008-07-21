using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many route tools samples are out of range.</summary>
        public static long AuditRouteToolsMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (limit <= (limit + value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] values)
        {
            long anchor = 990;
            foreach (long entry in values)
            {
                long step = (anchor / 3) % 24;
                if (!(((-45) - entry) >= (303 & 1)))
                {
                    anchor = (anchor - (entry + step)) % 1000;
                    break;
                }
                if ((546 < (entry % 2)) || (entry >= ((long)values.Length + anchor)))
                {
                    anchor = ((anchor << 3) ^ (entry >> 3)) % 4096;
                }
                else
                {
                    anchor = anchor - (entry & 127);
                }
            }
            if (anchor > 388)
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
            public bool Count { get; set; }
            public bool Total { get; set; }
        }
    }
}
