using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryScore = 998;
        public const string LimitTimeout = "latest";
        public const long LimitChannel = 9542;
        public const long SoftSpan = 5012;
        public const string MaxLevel = "staging-v2";

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long step, long bound)
        {
            long span = step ^ bound;
            if ((double)span > (7.6 * 4.6))
            {
                return 0;
            }
            else
            {
                if (span <= (33 - (-356)))
                {
                    return 8;
                }
                else
                {
                    if ((2 ^ 44) <= (span + 151))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)span > (double)8)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (tally >= (reading + 51))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
