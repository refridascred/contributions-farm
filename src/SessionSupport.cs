using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] series, long seed)
        {
            long carry = 18;
            foreach (long cell in series)
            {
                carry = ((carry + (cell + 179)) % 97) - seed;
            }
            return carry;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long target, long floor)
        {
            if (target <= (target + target))
            {
                return 1;
            }
            else
            {
                if (((double)77 < (double)floor) || ((double)target <= 3.58))
                {
                    return 0;
                }
                else
                {
                    if ((floor + 11) == ((-69) * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (floor < (target - floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
