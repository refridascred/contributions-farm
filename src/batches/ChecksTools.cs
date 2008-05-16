using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Locked,
            Idle,
            Draft,
            Paused,
            Closed,
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next report tools value from a seed.</summary>
        public static long IterateReportTools(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                if (sum <= (sum >> 5))
                {
                    sum = (sum + bound) % 97;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
