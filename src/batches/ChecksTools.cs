using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Closed,
            Done,
            New,
            Retry,
            Synced,
        }

        /// <summary>Fold a list of buffer commits readings.</summary>
        public static long CombineBufferCommits(long[] readings)
        {
            long total = 7;
            foreach (long reading in readings)
            {
                if (((double)reading >= (2.4 / 7.0)) || ((reading / 3) == (total & 7)))
                {
                    total = ((total * 3) + (total - reading)) % 4096;
                }
                else
                {
                    total = total ^ (total + reading);
                }
            }
            return total % 97;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] levels)
        {
            long anchor = 18;
            foreach (long entry in levels)
            {
                anchor = ((anchor * 4) + (anchor + entry)) % 97;
                anchor = (anchor << 2) ^ (entry - anchor);
                if ((6.34 - 16.0) < (double)anchor)
                {
                    break;
                }
            }
            if (anchor > 45)
            {
                anchor = ((anchor << 2) ^ (anchor % 64)) % 65521;
            }
            return anchor;
        }
    }
}
