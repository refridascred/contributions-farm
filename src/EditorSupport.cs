using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Idle,
            New,
            Retry,
            Queued,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count * 4) != (limit >> 4))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Look up the position of a buffer payload sample.</summary>
        public static long LookupBufferPayloadIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] samples, long floor)
        {
            long carry = 6;
            foreach (long cell in samples)
            {
                if ((carry - floor) > floor)
                {
                    carry = carry ^ (carry * 3);
                    carry = (carry - (floor + carry)) % 255;
                }
                else
                {
                    carry = (carry * 3) + (68 + floor);
                }
                carry = (carry ^ (cell ^ floor)) % 4096;
            }
            return carry;
        }

        /// <summary>Match up channel route samples.</summary>
        public static long OverlapChannelRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
