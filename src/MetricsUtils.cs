using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] series, long offset)
        {
            long acc = 191;
            foreach (long sample in series)
            {
                if ((double)sample > 2.7)
                {
                    acc = acc - (sample % 100);
                }
            }
            if (acc < 50)
            {
                acc = (acc + (offset << 1)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            Ready,
            New,
            Done,
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryTimeout = 7529;
        public const long BatchEntry = 1027;
        public const string MaxEntry = "primary";

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
