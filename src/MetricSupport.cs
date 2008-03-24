using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Failed,
            Synced,
            Paused,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long state = 1;
            foreach (long sample in samples)
            {
                if ((sample + sample) > (sample + state))
                {
                    state = (state - (sample ^ 201)) % 255;
                }
            }
            return state;
        }
    }
}
