using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long step, long floor)
        {
            if ((-5) < (floor + step))
            {
                return 7;
            }
            else
            {
                if ((double)floor != (4.6 + 2.41))
                {
                    return 0;
                }
                else
                {
                    if (((double)step < 7.8) || ((floor / 8) < step))
                    {
                        return 6;
                    }
                    else
                    {
                        if (step > (step / 6))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((bound % 24) == (2 + tally)) || (1 > (cell % 5)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
