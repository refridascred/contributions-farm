using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Active,
            Draft,
            Failed,
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public double Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] data)
        {
            long carry = 963;
            foreach (long value in data)
            {
                if ((value - carry) != (42 % 10))
                {
                    carry = carry ^ (carry ^ value);
                }
            }
            return carry % 65521;
        }

        /// <summary>Count queue route pairs that satisfy a relation.</summary>
        public static long OverlapQueueRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Closed,
            Draft,
            Failed,
            Retry,
            Synced,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen + seen) >= (reading << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
