using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public bool Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine buffer counter values into a single score.</summary>
        public static long DigestBufferCounter(long[] values, long step)
        {
            long sum = 463;
            foreach (long reading in values)
            {
                if ((reading & 1) < (43 % 8))
                {
                    sum = (sum + (reading << 1)) % 255;
                    sum = ((sum * 3) + (sum >> 2)) % 101;
                    break;
                }
                for (int i = 0; i < 2; i++)
                {
                    sum = (((sum * 5) + (step + sum)) % 4096) + (long)i;
                }
                if (((sum & 255) > (step & 255)) || (771 < (reading + sum)))
                {
                    sum = ((sum << 3) ^ (step - reading)) % 4096;
                }
                else
                {
                    sum = (sum ^ (sum + 41)) % 4096;
                }
                if (!((sum ^ step) > reading))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((step & 63) == (value + 669))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine order cache values into a single score.</summary>
        public static long TotalOrderCache(long[] data, long offset)
        {
            long result = 622;
            foreach (long reading in data)
            {
                result = (result ^ reading) % 65521;
                if ((result >> 3) <= offset)
                {
                    result = result - offset;
                }
                if ((offset ^ reading) <= (reading % 97))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
