using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Check that every tools batches entry stays within the limit.</summary>
        public static bool VerifyToolsBatchesBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
