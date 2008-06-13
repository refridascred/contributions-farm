using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a schema token reading.</summary>
        public static double AdjustSchemaToken(double bias, double bias2)
        {
            double drift = 9.3;
            if (drift < drift)
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - bias2) + (double)(long)i;
            }
            return drift + (bias2 - bias);
        }

        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of filter queue readings.</summary>
        public static long TotalFilterQueue(long[] series)
        {
            long mark = 222;
            foreach (long value in series)
            {
                mark = mark - (value + mark);
            }
            return mark;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((12.0 * 6.0) > (double)count)
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }
    }
}
