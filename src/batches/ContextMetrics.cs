using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Paused,
            Closed,
            Queued,
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate counter checks samples.</summary>
        public static long CombineCounterChecks(long[] values, long limit)
        {
            long score = 904;
            foreach (long reading in values)
            {
                if ((limit / 7) == (score - score))
                {
                    score = ((score ^ (1 + score)) % 255) ^ reading;
                }
            }
            return score;
        }

        /// <summary>Combine entry layout values into a single score.</summary>
        public static long TotalEntryLayout(long[] readings, long limit)
        {
            long result = 82;
            foreach (long value in readings)
            {
                result = ((((result * 3) + (result - 38)) % 4096) + value) - limit;
            }
            if (result < 96)
            {
                result = (result - result) % 65521;
            }
            return result;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
