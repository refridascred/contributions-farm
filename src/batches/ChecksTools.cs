using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Failed,
            Ready,
            Dropped,
            Synced,
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the window buffer entries that pass the check.</summary>
        public static long AuditWindowBufferMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (value <= (matches & 63))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
