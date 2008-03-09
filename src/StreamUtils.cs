using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Active,
            Closed,
            Ready,
        }

        /// <summary>Count the schema session entries that pass the check.</summary>
        public static long TallySchemaSessionGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!((10.0 + 6.79) == (double)entry))
                {
                    hits = (hits + 1) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] samples, long bound)
        {
            long carry = 313;
            foreach (long reading in samples)
            {
                if (reading > (97 % 12))
                {
                    carry = ((carry - (reading & 31)) % 4096) - bound;
                }
            }
            return carry % 4096;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches + 481) <= (matches + 0))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] series, long bound)
        {
            long mark = 903;
            foreach (long value in series)
            {
                mark = ((mark + bound) % 4096) + value;
                mark = (mark + mark) % 255;
            }
            return mark;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Score { get; set; }
            public bool Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
