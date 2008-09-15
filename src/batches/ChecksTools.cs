using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading % 16) != (offset - offset))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 683;
        public const string DefaultInterval = "open-1";
        public const long MaxTimeout = 8555;

        /// <summary>Match up cache batch samples.</summary>
        public static long CompareCacheBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
