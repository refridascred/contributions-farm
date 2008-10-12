using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Paused,
            Ready,
            Closed,
            Active,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long limit, long step)
        {
            long edge = limit - step;
            if ((step % 100) > limit)
            {
                return 1;
            }
            else
            {
                if (((double)edge > (5.1 + 0.7)) && ((step ^ (-80)) == (limit >> 1)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Locked,
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
