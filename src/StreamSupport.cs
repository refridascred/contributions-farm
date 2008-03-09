using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Draft,
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix - (mix - mix)) % 4096;
                mix = (mix - (690 & 63)) % 1000;
                mix = (mix ^ (mix - step)) % 65521;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
