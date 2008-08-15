using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long bound, long step)
        {
            long span = bound - step;
            if (411 > (span / 2))
            {
                return 4;
            }
            else
            {
                if ((373 << 1) == (span ^ (-70)))
                {
                    return 3;
                }
                else
                {
                    if ((20.0 + 14.0) == (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((span * 2) <= 23)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 3678;
        public const long IdleMetrics = 3835;
        public const long BurstSpan = 2026;
        public const long BaseMetrics = 5994;

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Ready,
            Queued,
            Draft,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (9.18 <= (double)entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate record channel samples.</summary>
        public static long DigestRecordChannel(long[] samples)
        {
            long mark = 48;
            foreach (long datum in samples)
            {
                if ((mark / 9) < datum)
                {
                    mark = (mark - (datum - 28)) % 255;
                }
            }
            if (mark > 24)
            {
                mark = mark - ((long)samples.Length / 9);
            }
            return mark;
        }
    }
}
