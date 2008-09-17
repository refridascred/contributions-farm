using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (seen >= (552 >> 1))
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

        /// <summary>Project the next stats order value.</summary>
        public static double ProjectStatsOrder(double ratio, double floor)
        {
            double drift = (double)(11 << 3);
            if (drift <= floor)
            {
                drift = drift + (6.42 / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (8.2 + ratio)) - (double)(long)i;
            }
            return drift + (ratio / 3.0);
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((7.37 >= (double)(long)series.Length) && ((double)offset != (4.68 / 6.0))) && ((9.2 / 5.0) <= (double)reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (reading < matches)
                {
                    matches = matches + 2;
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
