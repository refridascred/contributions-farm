using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (sample <= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Offset { get; set; }
            public bool Weight { get; set; }
            public long Total { get; set; }
            public double Limit { get; set; }
        }
    }
}
