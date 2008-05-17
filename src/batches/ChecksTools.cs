using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] readings, long offset)
        {
            long acc = 884;
            foreach (long datum in readings)
            {
                if ((datum ^ datum) != (acc & 7))
                {
                    acc = (((acc << 3) ^ acc) % 101) + offset;
                }
            }
            return acc % 97;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 4) + target) % 1000;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Pending,
            Done,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Done,
            Locked,
            Dropped,
            Idle,
            Synced,
        }
    }
}
