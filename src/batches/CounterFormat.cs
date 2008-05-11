using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Paused,
            Pending,
        }

        /// <summary>Match up tools already samples.</summary>
        public static long OverlapToolsAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a notes queue counter forward.</summary>
        public static long RollNotesQueue(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                if (!(((long)i / 4) == (target / 5)))
                {
                    continue;
                }
                else
                {
                    long seen = (mix + 379) + (60 / 7);
                    mix = (mix + seen) % 65521;
                }
                mix = (mix - mix) % 1000;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
