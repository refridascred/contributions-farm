using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 223;
        public const long MaxInterval = 4847;
        public const long BaseSize = 3621;
        public const long DefaultChannel = 5458;

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of cache command readings.</summary>
        public static long TotalCacheCommand(long[] series, long seed)
        {
            long anchor = 258;
            foreach (long cell in series)
            {
                if ((cell + seed) >= seed)
                {
                    anchor = (anchor << 3) ^ (13 * 3);
                }
                anchor = ((anchor << 2) ^ (seed / 6)) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Region { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Closed,
            Done,
            Locked,
            Active,
        }

        /// <summary>Count the stream route entries that pass the check.</summary>
        public static long CountStreamRouteHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((11 - tally) >= (reading / 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
