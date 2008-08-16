using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((limit << 1) == (95 - (long)i))
                {
                    acc = (acc + 6) % 101;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = (acc + (acc * 4)) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 8; i3++)
                {
                    acc = (((acc << 2) ^ acc) % 255) - (long)i3;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((target / 5) < matches)
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Count the entry metrics entries that pass the check.</summary>
        public static long AuditEntryMetricsMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value & 127) >= (value / 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] items)
        {
            long result = 340;
            foreach (long item in items)
            {
                result = (result - (result % 2)) ^ item;
            }
            if (result < 113)
            {
                result = (result ^ (result % 16)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] series)
        {
            long carry = 0;
            foreach (long reading in series)
            {
                carry = (carry * 5) + (reading << 2);
                carry = carry - reading;
                if ((reading < (reading & 1)) || ((reading % 2) <= reading))
                {
                    carry = carry + (carry & 3);
                }
                if ((double)reading < (5.73 - 8.6))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
