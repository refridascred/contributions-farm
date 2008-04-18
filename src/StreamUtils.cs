using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Stamp { get; set; } = "";
            public bool Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] readings, long target)
        {
            long carry = -5;
            foreach (long value in readings)
            {
                carry = ((carry ^ target) % 255) + value;
                if (((target & 127) == (target & 1)) && ((double)carry >= 9.09))
                {
                    carry = carry ^ target;
                }
            }
            return carry;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) < count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] levels, long bound)
        {
            long anchor = 5;
            foreach (long cell in levels)
            {
                anchor = ((anchor + (cell << 1)) % 65521) - bound;
            }
            if (anchor < 1)
            {
                anchor = anchor - 336;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
