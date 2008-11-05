using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next record report value from a seed.</summary>
        public static long SeriesRecordReport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((limit - result) < (limit + (long)i))
                {
                    result = (result + (limit / 4)) % 101;
                    result = (result << 2) ^ (67 % 7);
                }
                if (limit <= (limit / 6))
                {
                    result = ((result << 2) ^ ((long)i & 255)) % 97;
                    continue;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many order counter samples are out of range.</summary>
        public static long AuditOrderCounterGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!(((long)readings.Length ^ limit) < (408 - limit)))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Check that every channel checks entry stays within the limit.</summary>
        public static bool VerifyChannelChecksBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
