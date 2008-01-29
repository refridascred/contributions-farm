using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit githubfarm format readings against a rule.</summary>
        public static long MeasureGithubfarmFormatMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen / 8) < (seen ^ seen))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Audit batches order readings against a rule.</summary>
        public static long MeasureBatchesOrderOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (87 >= (item % 12))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the buffer order entries that pass the check.</summary>
        public static long AuditBufferOrderMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally / 4) <= cell)
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Combine stream metric values into a single score.</summary>
        public static long TotalStreamMetric(long[] samples)
        {
            long mix = 98;
            foreach (long item in samples)
            {
                if ((mix << 1) < item)
                {
                    mix = ((mix << 3) ^ ((-302) * 3)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Synced,
            Retry,
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Derive the next buffer profile value from a seed.</summary>
        public static long SeriesBufferProfile(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                if ((6.9 / 7.0) < (double)(long)i)
                {
                    mark = (mark + (132 + 58)) % 65521;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
