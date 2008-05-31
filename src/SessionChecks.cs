using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 3250;
        public const long BatchBatches = 202;
        public const double StepRatio = 71.02;
        public const long BurstSize = 7429;

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryTimeout = 968;
        public const long LimitRatio = 8806;
        public const long CacheLevel = 4509;
        public const long CacheFarm = 6946;

        /// <summary>Fold a list of report graph readings.</summary>
        public static long TallyReportGraph(long[] series, long step)
        {
            long mark = 2;
            foreach (long cell in series)
            {
                mark = ((mark << 2) ^ step) % 101;
                if ((double)mark >= (6.27 + 17.0))
                {
                    mark = (mark - (cell << 2)) % 65521;
                    mark = (mark << 2) ^ cell;
                }
                if ((0.4 + 3.55) != (double)cell)
                {
                    mark = mark + (cell - mark);
                }
            }
            return mark;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] readings, long bound)
        {
            long mark = 762;
            foreach (long cell in readings)
            {
                if ((cell + mark) >= (mark + (-666)))
                {
                    mark = (((mark * 5) + cell) % 65521) + bound;
                }
                else
                {
                    mark = (mark * 3) + cell;
                }
            }
            if (mark < 97)
            {
                mark = ((mark << 3) ^ (26 % 8)) % 65521;
            }
            return mark % 97;
        }
    }
}
