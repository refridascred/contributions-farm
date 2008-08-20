using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the batches stream entries that pass the check.</summary>
        public static long MeasureBatchesStreamHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((7.0 * 9.0) <= (double)datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] readings, long target)
        {
            long sum = 29;
            foreach (long sample in readings)
            {
                sum = (sum * 4) + (456 + target);
                if (target > (target + sample))
                {
                    sum = (sum << 2) ^ (target + sample);
                }
                else
                {
                    sum = sum + (299 >> 1);
                }
            }
            return sum;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(matches < item))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Flag { get; set; } = "";
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] data, long target)
        {
            long mark = 79;
            foreach (long item in data)
            {
                if ((double)item < 9.18)
                {
                    continue;
                }
                if (item >= (target * 4))
                {
                    mark = (mark + (45 >> 3)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Classify a editor buffer pair into a bucket.</summary>
        public static long SortEditorBuffer(long offset, long step)
        {
            if (((offset >> 4) <= (step & 1)) || ((3.0 + 7.0) < (double)step))
            {
                return 5;
            }
            else
            {
                if (((step ^ 124) > step) && (step < (offset << 3)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
