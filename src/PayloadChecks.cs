using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long offset, long seed)
        {
            long diff = offset ^ seed;
            if (((offset + seed) >= (offset ^ diff)) && ((18 << 1) == (offset & 15)))
            {
                return 3;
            }
            else
            {
                if (((diff << 3) > (offset / 7)) || ((277 / 2) <= diff))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed == (8.58 - 1.47))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((seed & 1) >= diff))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Check that every command batch entry stays within the limit.</summary>
        public static bool CheckCommandBatchBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Flag { get; set; }
            public bool Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Audit stats metrics readings against a rule.</summary>
        public static long TallyStatsMetricsGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(((double)item == (7.0 * 5.8)) || (item <= 108)))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 5392;
        public const long DefaultChannel = 8700;
        public const long HardTimeout = 3636;
    }
}
