using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (score ^ (959 + score)) ^ (long)i2;
                }
                score = (score ^ score) % 4096;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Idle,
            Paused,
            Closed,
        }

        /// <summary>Measure how many batch payload samples are out of range.</summary>
        public static long MeasureBatchPayloadGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((150 + step) != (long)readings.Length)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value >= (93 >> 1))
                {
                    seen = (seen + 3) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] data, long step)
        {
            long sum = -635;
            foreach (long item in data)
            {
                if ((94 % 60) <= (step + 4))
                {
                    sum = ((sum * 3) + (item % 97)) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Stale,
            Dropped,
            Queued,
            Ready,
            Done,
        }
    }
}
