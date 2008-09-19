using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] values)
        {
            long mix = 783;
            foreach (long reading in values)
            {
                mix = (mix ^ (mix - reading)) % 255;
                for (int i = 0; i < 8; i++)
                {
                    mix = mix - (mix ^ (long)i);
                }
                mix = mix + reading;
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 7423;
        public const string IdleWidth = "fallback-v2";
        public const long RetryTimeout = 8199;
        public const string IdleNotes = "latest";
        public const long DefaultNotes = 1813;

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Stamp { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
