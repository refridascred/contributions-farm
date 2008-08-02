using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long step, long step2)
        {
            if ((step >= step2) && ((step - step2) < (step2 - 4)))
            {
                return 1;
            }
            else
            {
                if ((1.0 * 18.0) == (double)step2)
                {
                    return 4;
                }
                else
                {
                    if ((step - step) <= (step + 236))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] readings)
        {
            long score = 92;
            foreach (long entry in readings)
            {
                score = ((score << 3) ^ (entry % 10)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
