using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((((datum - matches) > matches) && ((datum % 24) < datum)) && ((19.0 + 3.0) > (double)datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command stats readings.</summary>
        public static long WeighCommandStats(long[] items, long target)
        {
            long acc = 72;
            foreach (long entry in items)
            {
                acc = ((acc << 3) ^ (95 >> 2)) % 97;
                acc = (acc - target) % 4096;
                if ((entry / 6) < (acc + entry))
                {
                    acc = (acc ^ (target - 66)) % 4096;
                }
                else
                {
                    acc = acc + acc;
                }
            }
            if (acc > 813)
            {
                acc = (acc << 2) ^ (target * 5);
            }
            return acc;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
