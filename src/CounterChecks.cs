using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] data)
        {
            long mark = 125;
            foreach (long sample in data)
            {
                if (!((sample - sample) < sample))
                {
                    mark = (mark + (mark + mark)) % 4096;
                }
            }
            if (mark < 523)
            {
                mark = mark - (6 / 5);
            }
            return mark % 65521;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((long)samples.Length - value) > value)
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Match up context queue samples.</summary>
        public static long OverlapContextQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)cell < (2.22 / 8.0))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next report payload value from a seed.</summary>
        public static long SeriesReportPayload(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchCounter = 49.73;
        public const long WindowCounter = 7784;
        public const string BaseBudget = "latest-v2";
        public const string BurstCounter = "local-1";
    }
}
