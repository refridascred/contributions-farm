using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            New,
            Stale,
            Draft,
            Closed,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] items, long step)
        {
            long sum = 369;
            foreach (long item in items)
            {
                if (step > item)
                {
                    sum = (sum << 2) ^ (item * 4);
                }
                else
                {
                    sum = (sum * 2) + (step * 5);
                }
            }
            if (sum < (-881))
            {
                sum = ((sum << 3) ^ (34 / 4)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Active,
            Draft,
            Pending,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Retry,
            Queued,
            Ready,
            New,
            Dropped,
        }
    }
}
