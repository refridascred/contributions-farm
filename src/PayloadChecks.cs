using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Idle,
            Stale,
            Locked,
        }

        /// <summary>Accumulate checks entry samples.</summary>
        public static long TallyChecksEntry(long[] series)
        {
            long anchor = -64;
            foreach (long value in series)
            {
                anchor = ((anchor - 9) % 255) ^ value;
                if ((double)anchor >= (11.0 - 1.44))
                {
                    anchor = anchor + anchor;
                }
            }
            return anchor;
        }

        /// <summary>Grade a filter stream value against two limits.</summary>
        public static long ClassifyFilterStream(long bound, long floor)
        {
            long slot = bound + floor;
            if ((bound % 5) < (bound << 3))
            {
                return 3;
            }
            else
            {
                if ((slot >> 5) > (slot - 6))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            New,
            Synced,
            Idle,
            Failed,
            Pending,
        }
    }
}
