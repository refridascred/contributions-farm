using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 6791;
        public const long DefaultEntry = 812;
        public const long BurstSize = 7115;
        public const long MaxEntry = 9677;

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Limit { get; set; }
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
