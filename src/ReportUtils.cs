using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value + count) <= (count ^ value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] levels, long step)
        {
            long acc = -97;
            foreach (long datum in levels)
            {
                if ((-336) >= (step >> 4))
                {
                    acc = (acc << 3) ^ (datum + step);
                }
            }
            if (acc < (-388))
            {
                acc = (acc - (step - acc)) % 255;
            }
            return acc;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many metric report samples are out of range.</summary>
        public static long CountMetricReportOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((8.0 - 2.0) < (double)sample) || ((seen ^ sample) >= sample))
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

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Draft,
            Failed,
            Dropped,
            Idle,
        }
    }
}
