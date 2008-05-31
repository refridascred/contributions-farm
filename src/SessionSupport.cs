using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Count { get; set; }
            public string Owner { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Grade a commits batches value against two limits.</summary>
        public static long GradeCommitsBatches(long limit, long bound)
        {
            if (((double)bound > (0.3 * 2.0)) || ((bound + 48) >= bound))
            {
                return 7;
            }
            else
            {
                if ((bound + limit) <= (5 % 12))
                {
                    return 3;
                }
                else
                {
                    if (((bound + (-968)) > 992) && ((bound + limit) == ((-820) + limit)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)limit == (double)bound) && (bound > 18))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
