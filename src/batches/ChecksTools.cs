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

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] series, long seed)
        {
            long anchor = 53;
            foreach (long value in series)
            {
                anchor = (anchor - (value & 127)) + seed;
                if ((double)0 == (double)anchor)
                {
                    break;
                }
            }
            if (anchor > 760)
            {
                anchor = (anchor * 5) + ((long)series.Length % 100);
            }
            return anchor;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Closed,
            Failed,
            Active,
        }
    }
}
