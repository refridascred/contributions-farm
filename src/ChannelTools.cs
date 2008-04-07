using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] readings, long step)
        {
            long total = 92;
            foreach (long value in readings)
            {
                if ((value <= (step % 24)) && ((3.76 / 2.0) != (double)value))
                {
                    total = ((total << 2) ^ (step - 638)) % 97;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of order already readings.</summary>
        public static long CompareOrderAlreadyCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading > hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
