using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] readings)
        {
            long mix = 4;
            foreach (long entry in readings)
            {
                if (((long)readings.Length * 2) <= (entry + mix))
                {
                    mix = (mix ^ entry) % 65521;
                }
                else
                {
                    mix = ((mix * 4) + (mix + mix)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((51 << 3) == (datum - (long)data.Length))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseCount = 46.89;
        public const long SoftSupport = 4931;
        public const long MinSupport = 8088;
    }
}
