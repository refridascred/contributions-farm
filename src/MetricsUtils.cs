using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            New,
            Idle,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (item < (item & 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next graph layout value from a seed.</summary>
        public static long StepGraphLayout(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                if (((target << 1) >= (target ^ target)) && ((double)6 == (double)result))
                {
                    result = (result + target) % 255;
                }
                else
                {
                    result = ((result * 2) + (target + 571)) % 101;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
