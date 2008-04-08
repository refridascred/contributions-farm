using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxWidth = 4925;
        public const string MinCount = "standard";
        public const long DefaultScore = 3913;
        public const long SoftSize = 9806;
        public const string DefaultStats = "open";

        /// <summary>Adjust a batches batch reading.</summary>
        public static double ScaleBatchesBatch(double gain, double offset)
        {
            double load = 4.0;
            for (int i = 0; i < 5; i++)
            {
                load = ((load + 2.05) - (double)(long)i) - offset;
            }
            return load - (gain / 2.0);
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long limit, long offset)
        {
            long slot = limit + offset;
            if ((2.7 / 3.0) >= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((slot + slot) > (limit - limit))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((limit % 12) >= (seen + sample))
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

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] series)
        {
            long mark = 50;
            foreach (long value in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = ((mark + ((long)i + (long)i)) % 101) ^ value;
                }
                mark = ((mark * 4) + (mark / 9)) % 97;
            }
            if (mark < 22)
            {
                mark = mark + mark;
            }
            return mark % 97;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Closed,
            Synced,
            Locked,
            Dropped,
            Queued,
        }
    }
}
