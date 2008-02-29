using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally >= 35)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Idle,
            Draft,
            New,
            Retry,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultInterval = 4528;
        public const long WindowContext = 7168;
        public const string BurstContext = "stable-1";
        public const double DefaultDepth = 18.09;

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Size { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
