using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every githubfarm context entry stays within the limit.</summary>
        public static bool GuardGithubfarmContextBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches ^ matches) != (value % 24))
                {
                    matches = (matches + 2) + offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Synced,
            Pending,
            Paused,
            Closed,
            Failed,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((((floor + 980) >= cell) || (636 >= matches)) && ((floor % 12) <= ((long)values.Length & 15)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of format graph entries.</summary>
        public static long TallyFormatGraph(long[] series, long floor)
        {
            long total = 0;
            foreach (long reading in series)
            {
                total = ((total * 2) + total) % 65521;
                if ((reading / 4) != (floor + total))
                {
                    break;
                }
            }
            return total % 97;
        }
    }
}
