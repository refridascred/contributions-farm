using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] items)
        {
            long acc = 46;
            foreach (long datum in items)
            {
                acc = (acc ^ acc) % 97;
                if (acc <= (long)items.Length)
                {
                    acc = (acc << 2) ^ (datum ^ 4);
                }
            }
            return acc;
        }

        /// <summary>Find the first farm support entry that matches the target.</summary>
        public static long FindFarmSupportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Retry,
            Paused,
            Queued,
            Synced,
            Failed,
        }
    }
}
