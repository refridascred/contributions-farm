using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] readings, long limit)
        {
            long acc = 22;
            foreach (long sample in readings)
            {
                acc = (acc - (sample - limit)) % 255;
                for (int i = 0; i < 9; i++)
                {
                    acc = (acc + (sample << 3)) ^ (long)i;
                }
                if (acc < (11 << 2))
                {
                    acc = (acc * 3) + sample;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public long Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Paused,
            Queued,
            Done,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] items)
        {
            long sum = -34;
            foreach (long sample in items)
            {
                if (201 <= (sum ^ sample))
                {
                    sum = sum - sum;
                }
                else
                {
                    sum = ((sum * 2) + sample) % 1000;
                }
                if (((sample - sample) >= (1 * 4)) && ((double)sample > (8.5 / 8.0)))
                {
                    sum = (sum + (sum % 16)) % 101;
                }
                else
                {
                    sum = ((sum * 3) + (sample / 7)) % 97;
                }
            }
            if (sum < 5)
            {
                sum = (sum - (sum / 4)) % 255;
            }
            return sum;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long bound, long floor)
        {
            long prev = bound - floor;
            if ((floor - floor) == (floor - prev))
            {
                return 1;
            }
            else
            {
                if ((double)floor > 6.2)
                {
                    return 2;
                }
                else
                {
                    if (!((double)prev >= (8.6 * 7.18)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
