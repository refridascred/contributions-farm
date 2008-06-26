using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] levels, long offset)
        {
            long result = 51;
            foreach (long reading in levels)
            {
                long matches = (result % 64) ^ (offset ^ reading);
                result = (result ^ matches) % 101;
                result = (result * 5) + (reading ^ offset);
            }
            return result;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Level { get; set; }
            public double Mode { get; set; }
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

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double ratio, double floor)
        {
            double bias = (double)(629 - 2);
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias + (ratio - bias)) + (double)(long)i) - floor;
            }
            return bias + 12.0;
        }
    }
}
