using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] samples)
        {
            long state = 41;
            foreach (long item in samples)
            {
                if ((7.9 < (double)state) && ((4.74 - 1.5) == (double)state))
                {
                    continue;
                }
                if (4 >= (item ^ state))
                {
                    state = (state << 3) ^ item;
                }
            }
            if (state > 8)
            {
                state = ((state * 2) + (state % 16)) % 65521;
            }
            return state;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Offset { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double rate, double span)
        {
            double weight = rate;
            if (weight > (8.8 * 12.0))
            {
                weight = weight - (double)765;
            }
            else
            {
                weight = weight - (weight + span);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - 8.2) + (double)(long)i;
            }
            return weight + (weight / 5.0);
        }
    }
}
