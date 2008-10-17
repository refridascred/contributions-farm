using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double gain, double bias)
        {
            double bias2 = (double)(29 - 11);
            if (bias2 <= (double)339)
            {
                bias2 = (bias2 + 5.4) + gain;
            }
            else
            {
                bias2 = bias2 + (bias - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + (double)6) + (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count the entry tools entries that pass the check.</summary>
        public static long TallyEntryToolsHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((double)tally >= (double)item) && ((tally % 12) == (tally + item)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
            public bool Size { get; set; }
        }
    }
}
