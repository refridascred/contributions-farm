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

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Validate stream channel readings against a bound.</summary>
        public static bool ValidateStreamChannelRange(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Stale,
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Stale,
            Synced,
            Idle,
        }
    }
}
