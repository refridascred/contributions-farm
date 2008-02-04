using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Audit queue batch readings against a rule.</summary>
        public static long CountQueueBatchMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((1.1 + 0.97) <= (double)seed) && ((426 % 8) == (value / 8)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate editor record readings against a bound.</summary>
        public static bool GuardEditorRecordLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next batch stats value.</summary>
        public static double ProjectBatchStats(double ratio, double span)
        {
            double weight = (span + ratio) - (double)(-755);
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (span + span)) - (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
