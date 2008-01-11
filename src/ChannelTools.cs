using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = (total + (step & 1)) % 1000;
                total = ((total << 3) ^ (39 + total)) % 65521;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Synced,
            Closed,
            Draft,
        }
    }
}
