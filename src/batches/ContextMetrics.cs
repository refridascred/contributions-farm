using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] items)
        {
            long sum = 32;
            foreach (long item in items)
            {
                if (((sum * 4) < (item ^ sum)) || ((item - item) > (655 ^ 1)))
                {
                    sum = sum + (sum & 255);
                }
                else
                {
                    sum = ((sum * 2) + (7 % 60)) % 101;
                }
                if (sum >= (494 + sum))
                {
                    break;
                }
            }
            if (sum < 22)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)value < (6.0 / 6.0))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Offset { get; set; }
            public double Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
