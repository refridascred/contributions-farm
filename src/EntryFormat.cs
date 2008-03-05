using System;

namespace Common.Utilities
{
    /// <summary>Entry format helpers.</summary>
    public static class EntryFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheChecks = "legacy";
        public const double BurstChecks = 4.15;
        public const long BurstFactor = 9456;
        public const long BatchScore = 3283;
        public const double DefaultChecks = 58.34;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count < reading) && (((7.6 / 8.0) == (double)reading) && ((reading - count) < (count % 7))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count support profile pairs that satisfy a relation.</summary>
        public static long PairSupportProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Region { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
        }
    }
}
