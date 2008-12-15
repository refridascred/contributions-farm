using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate notes stats samples.</summary>
        public static long TallyNotesStats(long[] items, long step)
        {
            long mix = 57;
            foreach (long entry in items)
            {
                if (4 <= entry)
                {
                    mix = ((mix * 3) + (mix << 3)) + step;
                }
            }
            return mix;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Paused,
            Pending,
            Locked,
            Done,
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Failed,
            Done,
            Ready,
        }
    }
}
