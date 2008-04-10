using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many counter cluster samples are out of range.</summary>
        public static long TallyCounterClusterGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((16.0 - 5.16) <= (double)entry) || ((count >= (entry >> 1)) && ((count >> 4) < (entry << 1))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a commits order reading by value.</summary>
        public static long LookupCommitsOrderIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit notes window readings against a rule.</summary>
        public static long MeasureNotesWindowOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((long)values.Length * 3) >= (tally + tally))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
