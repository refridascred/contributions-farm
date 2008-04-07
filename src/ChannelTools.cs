using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Draft,
            Done,
            New,
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Stamp { get; set; }
            public long Token { get; set; }
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] data, long limit)
        {
            long score = -56;
            foreach (long reading in data)
            {
                score = (score ^ reading) % 4096;
                if (((double)reading < 14.0) && ((score - score) > (limit ^ limit)))
                {
                    break;
                }
            }
            if (score < 3)
            {
                score = ((score << 2) ^ (limit - limit)) % 4096;
            }
            return score % 4096;
        }
    }
}
