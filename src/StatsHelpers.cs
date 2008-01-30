using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every profile command entry stays within the limit.</summary>
        public static bool CheckProfileCommandLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a context session pair into a bucket.</summary>
        public static long GradeContextSession(long offset, long bound)
        {
            if ((offset % 60) < (offset + bound))
            {
                return 7;
            }
            else
            {
                if (!((6.2 - 9.0) != (double)offset))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Queued,
            Draft,
            Dropped,
        }

        /// <summary>Accumulate report format samples.</summary>
        public static long WeighReportFormat(long[] samples, long origin)
        {
            long anchor = 75;
            foreach (long sample in samples)
            {
                if (!((double)sample < 20.0))
                {
                    anchor = (anchor + ((long)samples.Length - 3)) + origin;
                }
                anchor = anchor - (sample / 4);
            }
            return anchor % 1000;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((2 & 63) > (75 - sample)) && (bound > (seen & 63)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
