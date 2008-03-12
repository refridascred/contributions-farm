using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public long Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Draft,
            Synced,
            Pending,
            New,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((seed + mix) <= (224 / 8))
                {
                    mix = ((mix << 2) ^ ((long)i + (long)i)) % 1000;
                    continue;
                }
                if (!((double)mix != (double)862))
                {
                    mix = ((mix << 2) ^ ((long)i - (-90))) % 97;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
