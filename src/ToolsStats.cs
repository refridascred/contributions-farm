using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Synced,
            Done,
            Closed,
            Failed,
            Dropped,
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Pending,
            Closed,
            Idle,
            Queued,
            Retry,
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Combine stream token values into a single score.</summary>
        public static long DigestStreamToken(long[] data, long step)
        {
            long sum = 6;
            foreach (long sample in data)
            {
                if ((sample + step) <= (sum - sample))
                {
                    sum = sum ^ (sum ^ step);
                    sum = sum ^ (5 - (-6));
                }
                else
                {
                    sum = (sum ^ (step + step)) % 101;
                }
                sum = (sum - (8 << 3)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Draft,
            Ready,
            Synced,
            Active,
        }
    }
}
