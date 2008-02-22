using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first profile editor entry that matches the target.</summary>
        public static long LocateProfileEditorIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Idle,
            Ready,
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix + (origin + origin)) % 101;
                mix = ((mix * 5) + (99 - origin)) % 101;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 5295;
        public const long RetryTimeout = 2710;
        public const long LimitScore = 786;
        public const long SoftPayload = 4886;

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
