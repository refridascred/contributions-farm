using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Paused,
            Idle,
            Done,
            Active,
            Stale,
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix + (long)i) % 1000;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((seen + value) <= (seen ^ 847)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
