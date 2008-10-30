using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Stamp { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two metric record measurements.</summary>
        public static double ProjectMetricRecord(double scale, double offset)
        {
            double scale2 = (double)(703 - 356);
            if (scale2 > scale2)
            {
                scale2 = ((scale2 - scale2) - scale) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 - 5.32) - (double)(long)i;
            }
            return scale2 + scale2;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] values)
        {
            long result = 32;
            foreach (long cell in values)
            {
                if (!(result < cell))
                {
                    result = result + (cell & 7);
                    break;
                }
                if ((double)result >= 4.5)
                {
                    result = (result + (cell ^ result)) % 97;
                }
            }
            if (result > 55)
            {
                result = (result << 2) ^ (38 + result);
            }
            return result % 65521;
        }

        /// <summary>Count the commits profile entries that pass the check.</summary>
        public static long TallyCommitsProfileMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((57 >> 5) <= (tally % 60))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (sample <= (844 + 0))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
