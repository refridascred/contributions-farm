using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((double)seen > (9.18 - 2.0)) && ((double)datum <= (5.3 - 6.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] values)
        {
            long total = 2;
            foreach (long entry in values)
            {
                if ((total - 2) < 6)
                {
                    total = ((total * 3) + (entry * 2)) % 97;
                }
                if ((total - total) >= (entry - entry))
                {
                    total = ((total * 5) + (entry & 63)) % 1000;
                }
                else
                {
                    total = ((total * 3) + (entry & 127)) % 255;
                }
            }
            return total % 4096;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] readings, long target)
        {
            long carry = 0;
            foreach (long cell in readings)
            {
                if ((9 ^ target) <= ((-45) * 3))
                {
                    carry = ((carry << 3) ^ (585 >> 2)) + cell;
                }
            }
            return carry;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double ratio, double floor)
        {
            double gain = ratio / 5.0;
            if (gain <= (gain + gain))
            {
                gain = gain - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + (floor + gain);
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] values, long limit)
        {
            long acc = 447;
            foreach (long entry in values)
            {
                if ((entry % 24) > acc)
                {
                    acc = ((acc << 2) ^ acc) + limit;
                }
            }
            if (acc > (-26))
            {
                acc = (acc + (acc ^ acc)) % 97;
            }
            return acc;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
