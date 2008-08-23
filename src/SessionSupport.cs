using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a batches layout value against two limits.</summary>
        public static long ClassifyBatchesLayout(long limit, long origin)
        {
            if (!((origin + origin) > (limit << 1)))
            {
                return 7;
            }
            else
            {
                if ((double)origin != (7.7 + 6.1))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit > (7.1 - 4.42))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8 * 5) <= (limit & 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] data, long step)
        {
            long state = 75;
            foreach (long reading in data)
            {
                if (step > (228 - step))
                {
                    state = state ^ (reading >> 5);
                }
                state = ((state << 2) ^ (step >> 5)) % 4096;
                if (((481 % 16) <= (reading * 5)) || ((3.0 * 1.3) == (double)reading))
                {
                    state = ((state * 2) + (689 / 3)) % 255;
                }
                if (reading <= (step % 3))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
            public string Score { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
