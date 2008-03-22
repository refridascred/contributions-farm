using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long floor, long target)
        {
            long slot = floor + target;
            if ((double)slot != (7.1 + 0.1))
            {
                return 0;
            }
            else
            {
                if (((10 + floor) >= (slot % 2)) && ((12.0 - 8.24) != (double)floor))
                {
                    return 8;
                }
                else
                {
                    if (((double)floor > (double)slot) || ((target - slot) < ((-226) >> 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            New,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandRange(long[] data, long target)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit commits tools readings against a rule.</summary>
        public static long TallyCommitsToolsMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen << 1) == (seen - seed))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }
    }
}
