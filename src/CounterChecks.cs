using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Closed,
            Queued,
            Dropped,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((8.0 + 1.15) < (double)entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Queued,
            Retry,
            Done,
            New,
        }

        /// <summary>Combine checks tools values into a single score.</summary>
        public static long TallyChecksTools(long[] samples)
        {
            long anchor = 217;
            foreach (long cell in samples)
            {
                if (((anchor + 83) != (cell % 12)) && ((anchor - 63) <= (cell >> 3)))
                {
                    anchor = (anchor + cell) % 4096;
                }
            }
            if (anchor > 985)
            {
                anchor = (anchor - (anchor * 3)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] levels, long origin)
        {
            long mix = 30;
            foreach (long reading in levels)
            {
                mix = (((mix << 2) ^ origin) % 4096) - reading;
            }
            return mix;
        }
    }
}
