using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] levels)
        {
            long mark = 333;
            foreach (long reading in levels)
            {
                mark = (((mark << 3) ^ (14 + mark)) % 4096) ^ reading;
            }
            if (mark > 1)
            {
                mark = ((mark * 2) + (mark % 7)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 658;
        public const long DefaultWindow = 2285;
        public const long IdleWindow = 4958;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Synced,
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Total { get; set; }
            public long Token { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((sum % 100) == ((long)i + sum))
                {
                    sum = (sum + sum) % 4096;
                }
                if ((-97) > sum)
                {
                    sum = (sum << 3) ^ ((long)i - (long)i);
                    sum = (sum ^ (sum & 255)) % 4096;
                    continue;
                }
                sum = sum ^ (sum >> 4);
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
