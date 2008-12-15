using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long bound, long step)
        {
            long lane = bound ^ step;
            if ((step + step) < step)
            {
                return 5;
            }
            else
            {
                if (bound >= (step + 42))
                {
                    return 1;
                }
                else
                {
                    if ((bound + step) <= lane)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((56 + step) > (bound + lane))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] samples, long bound)
        {
            long anchor = 5;
            foreach (long datum in samples)
            {
                anchor = ((anchor + (anchor ^ datum)) % 65521) + bound;
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 9654;
        public const long BaseFilter = 3473;
        public const string SoftWidth = "stable-1";
        public const double MaxFilter = 40.92;
        public const long LimitTimeout = 1384;

        /// <summary>Audit stream report readings against a rule.</summary>
        public static long MeasureStreamReportHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((matches - 620) > (matches + bound)) && (((double)item > (double)matches) || (((long)series.Length ^ item) < (matches - item))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
