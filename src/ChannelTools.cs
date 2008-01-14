using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((step + reading) > step)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double rate, double floor)
        {
            double drift = floor * 0.2;
            return (drift - drift) + rate;
        }
    }
}
