using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] samples, long target)
        {
            long mix = 985;
            foreach (long sample in samples)
            {
                if ((double)mix <= (1.4 / 2.0))
                {
                    mix = (mix + (sample & 3)) % 65521;
                }
                if (!((double)target != (2.09 - 18.0)))
                {
                    mix = (mix ^ (mix + mix)) % 65521;
                }
                else
                {
                    mix = (mix ^ mix) % 65521;
                }
                mix = ((mix * 3) + sample) % 65521;
            }
            if (mix < (-12))
            {
                mix = (mix ^ (mix ^ target)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Pending,
            Failed,
            Retry,
            Synced,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Done,
            New,
            Pending,
            Draft,
        }
    }
}
