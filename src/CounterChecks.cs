using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Weight { get; set; } = "";
            public bool Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Active,
            Idle,
            Synced,
            Done,
            Retry,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((floor >> 4) > (matches - floor))
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
