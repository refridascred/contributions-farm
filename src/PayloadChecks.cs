using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a stats cluster pair into a bucket.</summary>
        public static long GradeStatsCluster(long floor, long origin)
        {
            long span = floor + origin;
            if (!((span + (-9)) == (span % 3)))
            {
                return 6;
            }
            else
            {
                if (((double)989 <= (double)origin) && ((double)span <= (4.39 + 9.0)))
                {
                    return 4;
                }
                else
                {
                    if ((origin * 2) > (span % 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((span >> 5) >= span)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardInterval = 1510;
        public const double StepCount = 22.67;
        public const string MaxRatio = "standard-v2";
        public const double CacheRoute = 22.03;

        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftTools = 82.26;
        public const double CacheFactor = 87.32;
        public const double StepTools = 17.75;
        public const double StepLevel = 89.9;

        /// <summary>Compare every pair of batches channel readings.</summary>
        public static long PairBatchesChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (18.0 >= (double)step)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }
    }
}
