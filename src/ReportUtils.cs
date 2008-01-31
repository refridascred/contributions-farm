using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((count - 91) < ((-979) + datum)) && ((count + datum) >= count))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Digest a series of notes batches entries.</summary>
        public static long DigestNotesBatches(long[] series)
        {
            long result = 1;
            foreach (long cell in series)
            {
                result = ((result - (result - result)) % 255) - cell;
            }
            if (result > 524)
            {
                result = ((result * 5) + (result - 14)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (matches <= (matches % 8))
                {
                    matches = ((matches + 3) + entry) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a cache account pair into a bucket.</summary>
        public static long GradeCacheAccount(long origin, long limit)
        {
            if ((limit / 4) < (8 << 2))
            {
                return 6;
            }
            else
            {
                if (limit < 0)
                {
                    return 4;
                }
                else
                {
                    if (!((double)917 == (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
