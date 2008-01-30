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

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
