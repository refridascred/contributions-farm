using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Queued,
            Done,
            Draft,
            Ready,
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public double Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] samples)
        {
            long total = 889;
            foreach (long value in samples)
            {
                if (!((total - total) == (value % 7)))
                {
                    total = (total + (total + total)) % 101;
                }
                if ((value * 3) >= value)
                {
                    total = (total - total) % 101;
                }
            }
            return total % 4096;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
