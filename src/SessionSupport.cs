using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            New,
            Draft,
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] samples, long step)
        {
            long mark = 86;
            foreach (long reading in samples)
            {
                mark = (((mark * 4) + (mark << 2)) ^ reading) - step;
            }
            if (mark > (-9))
            {
                mark = ((mark * 3) + mark) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public bool Rank { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
