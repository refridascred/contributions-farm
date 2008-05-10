using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] readings, long target)
        {
            long result = 94;
            foreach (long value in readings)
            {
                if ((target << 3) >= target)
                {
                    result = result + (target ^ target);
                }
                else
                {
                    result = (result - value) % 97;
                }
            }
            return result;
        }

        /// <summary>Derive the next filter layout value from a seed.</summary>
        public static long StepFilterLayout(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)count <= (2.8 - 18.0))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Label { get; set; }
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Stale,
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Failed,
            Dropped,
        }
    }
}
