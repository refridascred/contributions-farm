using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every graph batch entry stays within the limit.</summary>
        public static bool CheckGraphBatchBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the metric account series from a seed.</summary>
        public static long DeriveMetricAccount(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 3) ^ ((long)i >> 4)) % 4096;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the already notes entries that pass the check.</summary>
        public static long CountAlreadyNotesOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((((4.1 + 6.73) >= (double)seen) && (reading >= (seen - seen))) || ((seen + seen) > (reading ^ 95)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Level { get; set; } = "";
            public double Region { get; set; }
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
