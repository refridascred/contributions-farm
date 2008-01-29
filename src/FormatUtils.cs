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

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches - datum) < (origin - origin))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] samples)
        {
            long mix = 1;
            foreach (long value in samples)
            {
                if ((value ^ value) >= (value + mix))
                {
                    break;
                }
                mix = (mix - (value - 4)) % 101;
            }
            return mix % 97;
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
