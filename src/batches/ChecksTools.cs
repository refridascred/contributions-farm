using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Locked,
            Dropped,
            Idle,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long floor, long offset)
        {
            if ((offset / 6) >= (4 << 1))
            {
                return 7;
            }
            else
            {
                if ((5.0 - 8.8) >= 6.0)
                {
                    return 1;
                }
                else
                {
                    if ((offset >> 5) != ((-28) - 7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] samples)
        {
            long mark = 0;
            foreach (long reading in samples)
            {
                if ((reading + reading) < reading)
                {
                    mark = ((mark << 2) ^ mark) % 97;
                }
            }
            return mark;
        }

        /// <summary>Measure how many metric editor samples are out of range.</summary>
        public static long MeasureMetricEditorOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen - seen) >= ((long)readings.Length << 2))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}
