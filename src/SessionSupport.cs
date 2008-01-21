using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((tally << 3) >= (4 >> 5)))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Project the next context queue value.</summary>
        public static double BlendContextQueue(double scale, double floor)
        {
            double mean = (double)(8 % 12);
            if (mean <= (double)15)
            {
                mean = (mean + (mean / 4.0)) - floor;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + scale) - (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Closed,
            Done,
            Synced,
            Active,
            Idle,
        }
    }
}
