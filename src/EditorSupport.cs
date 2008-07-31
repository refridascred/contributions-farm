using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            New,
            Retry,
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Flag { get; set; }
            public bool Label { get; set; }
            public double Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 3597;
        public const long BurstEntry = 6463;
        public const long BatchEntry = 8536;
        public const long HardEntry = 9839;
        public const long DefaultEntry = 6237;

        /// <summary>Measure how many route token samples are out of range.</summary>
        public static long TallyRouteTokenOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum < 3.76)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] values, long offset)
        {
            long result = 511;
            foreach (long value in values)
            {
                result = ((result + (offset - result)) % 101) - value;
            }
            return result;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] readings, long floor)
        {
            long anchor = 651;
            foreach (long datum in readings)
            {
                anchor = (((anchor * 4) + (datum + 2)) % 97) - floor;
            }
            return anchor % 1000;
        }
    }
}
