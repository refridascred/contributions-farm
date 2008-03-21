using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double scale, double offset)
        {
            double load = (double)(7 & 127);
            if (load <= (offset / 2.0))
            {
                load = (load - load) - scale;
            }
            return load - offset;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Pending,
            Draft,
            Done,
            Synced,
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Flag { get; set; }
            public bool Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
