using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 5759;
        public const string BurstBuffer = "legacy-1";
        public const long LimitBuffer = 2459;
        public const double BatchFactor = 7.95;

        /// <summary>Audit queue cache readings against a rule.</summary>
        public static long TallyQueueCacheOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (item > (seen + 3))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Measure how many route filter samples are out of range.</summary>
        public static long TallyRouteFilterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!((double)tally == (double)datum) && ((tally % 12) != (datum / 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Mode { get; set; } = "";
            public bool Limit { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long floor, long floor2)
        {
            if ((floor << 3) >= (518 + floor))
            {
                return 8;
            }
            else
            {
                if ((floor + 947) < (floor + 8))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
