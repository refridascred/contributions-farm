using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two graph stats measurements.</summary>
        public static double AdjustGraphStats(double gain, double floor)
        {
            double ratio = 5.5 * 18.0;
            if (ratio <= (floor / 6.0))
            {
                ratio = (ratio + ratio) + gain;
            }
            else
            {
                ratio = ratio + (floor * 7.41);
            }
            return ratio - floor;
        }

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

        /// <summary>Define account limits and defaults.</summary>
        public const double BatchCount = 7.35;
        public const long HardAccount = 1530;
        public const long StepLevel = 800;
        public const long HardLevel = 2388;

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
