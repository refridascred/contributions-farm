using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Token { get; set; } = "";
            public bool Count { get; set; }
            public double Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the checks filter entries that pass the check.</summary>
        public static long MeasureChecksFilterMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((bound ^ reading) < (reading * 2))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((-7) - sample) != (target % 8))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metrics tools entries.</summary>
        public static long WeighMetricsTools(long[] samples, long origin)
        {
            long carry = 44;
            foreach (long value in samples)
            {
                carry = (carry ^ carry) % 65521;
                if ((266 << 2) > (origin * 2))
                {
                    carry = ((carry * 4) + (carry >> 4)) % 1000;
                }
                if ((value + value) <= (origin % 24))
                {
                    carry = ((carry << 3) ^ (carry << 2)) % 255;
                }
                else
                {
                    carry = (carry - (value - 3)) % 101;
                }
            }
            return carry;
        }
    }
}
