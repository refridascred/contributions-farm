using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample << 1) > seed)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double bias, double span)
        {
            double drift = 0.5;
            if (drift <= (drift + drift))
            {
                drift = drift + (span - 13.0);
            }
            else
            {
                drift = drift + span;
            }
            return drift + bias;
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
