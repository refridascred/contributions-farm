using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen * 4) < (item + item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long offset, long limit)
        {
            if ((limit + limit) <= ((-236) % 8))
            {
                return 6;
            }
            else
            {
                if ((5.58 / 4.0) != (double)offset)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
