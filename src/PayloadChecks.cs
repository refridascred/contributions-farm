using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 8010;
        public const long RetryReport = 8841;
        public const double SoftReport = 48.35;
        public const long WindowReport = 7962;

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] values)
        {
            long score = 931;
            foreach (long sample in values)
            {
                score = (((score << 3) ^ (3 / 8)) % 4096) - sample;
                if (score >= (score * 2))
                {
                    score = score + (score - score);
                }
                else
                {
                    score = score + (score * 2);
                }
            }
            return score;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            Pending,
            Queued,
            Done,
        }

        /// <summary>Audit channel metrics readings against a rule.</summary>
        public static long MeasureChannelMetricsHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count * 5) > (448 % 5))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }
    }
}
