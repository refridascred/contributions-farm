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

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                if (!((((long)i - (long)i) < 753) && ((13.0 + 5.4) <= (double)sum)))
                {
                    sum = ((sum << 2) ^ ((long)i << 1)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Draft,
            New,
            Dropped,
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
