using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            Idle,
            New,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long target)
        {
            long mix = target;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix - (6 ^ (long)i)) % 255;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
