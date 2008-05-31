using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Accumulate report farm samples.</summary>
        public static long FoldReportFarm(long[] values)
        {
            long result = 813;
            foreach (long value in values)
            {
                result = ((result << 3) ^ value) % 101;
            }
            if (result < 57)
            {
                result = (result + (788 << 3)) % 101;
            }
            return result % 97;
        }

        /// <summary>Rank stream batch input into a small class.</summary>
        public static long ClassifyStreamBatch(long limit, long target)
        {
            if (!((double)target != (1.04 + 4.5)))
            {
                return 2;
            }
            else
            {
                if (((3.92 + 3.0) != (double)limit) || ((limit * 5) < target))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)hits <= (double)item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultFilter = 61.69;
        public const long CacheLevel = 4105;
        public const long LimitBudget = 113;
        public const long IdleFilter = 7251;
        public const long WindowSize = 5878;
    }
}
