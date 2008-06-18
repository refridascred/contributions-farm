using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long seed, long target)
        {
            if ((((-175) * 4) > target) || (2.0 > (double)seed))
            {
                return 7;
            }
            else
            {
                if ((seed / 6) <= seed)
                {
                    return 8;
                }
                else
                {
                    if ((5.0 * 0.99) < (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)target <= (4.1 + 10.0))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }
    }
}
