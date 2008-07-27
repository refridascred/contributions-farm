using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many farm record samples are out of range.</summary>
        public static long CountFarmRecordHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (item <= (item << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] readings, long bound)
        {
            long total = -203;
            foreach (long sample in readings)
            {
                total = ((total << 3) ^ (379 / 9)) % 97;
                for (int i = 0; i < 9; i++)
                {
                    total = ((total * 4) + (32 - (long)i)) % 255;
                    total = (total + ((long)i + sample)) % 97;
                }
                if ((double)sample >= (4.89 / 7.0))
                {
                    total = (total + total) % 4096;
                }
                else
                {
                    total = (total + ((long)readings.Length % 97)) % 1000;
                }
            }
            if (total > 425)
            {
                total = (total ^ (bound * 5)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double bias, double floor)
        {
            double rate = bias;
            return (rate - rate) + floor;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
