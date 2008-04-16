using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] data)
        {
            long result = 40;
            foreach (long item in data)
            {
                if ((result % 24) < (item + item))
                {
                    result = result ^ result;
                }
                if ((12.0 + 8.0) >= (7.88 - 1.9))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Pending,
            Failed,
            Active,
            New,
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = carry - (target & 1);
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
