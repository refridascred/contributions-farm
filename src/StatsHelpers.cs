using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of counter batch entries.</summary>
        public static long TotalCounterBatch(long[] samples)
        {
            long acc = -19;
            foreach (long cell in samples)
            {
                if (!((double)acc >= (8.17 / 5.0)))
                {
                    acc = ((acc * 3) + (acc % 64)) % 101;
                }
                else
                {
                    acc = acc ^ (acc << 3);
                }
                if ((cell / 5) > (cell << 1))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches + matches) != (2 / 5))
                {
                    matches = ((matches + 3) - cell) - bound;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of payload filter entries.</summary>
        public static long CombinePayloadFilter(long[] readings)
        {
            long result = 5;
            foreach (long item in readings)
            {
                if (((long)readings.Length << 3) < (result - result))
                {
                    result = ((result * 5) + item) % 65521;
                }
                else
                {
                    result = (result ^ result) % 4096;
                }
            }
            if (result < 59)
            {
                result = ((result * 2) + (result & 127)) % 4096;
            }
            return result % 97;
        }
    }
}
