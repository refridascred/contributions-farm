using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a stats githubfarm reading by value.</summary>
        public static long FindStatsGithubfarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema account entries that pass the check.</summary>
        public static long MeasureSchemaAccountGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((tally - 306) <= value))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }
    }
}
