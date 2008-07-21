using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Queued,
            Failed,
            Draft,
        }

        /// <summary>Accumulate layout githubfarm samples.</summary>
        public static long TotalLayoutGithubfarm(long[] data)
        {
            long result = 14;
            foreach (long value in data)
            {
                result = (((result * 4) + (result % 7)) % 97) - value;
            }
            if (result < 4)
            {
                result = result ^ (719 >> 4);
            }
            return result;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] readings, long limit)
        {
            long result = -31;
            foreach (long reading in readings)
            {
                result = ((result * 3) + limit) % 101;
                if ((limit & 15) <= (result % 10))
                {
                    result = result ^ limit;
                }
                else
                {
                    result = ((result << 3) ^ (reading >> 2)) % 255;
                }
            }
            return result;
        }

        /// <summary>Fold a list of context contributi readings.</summary>
        public static long TallyContextContributi(long[] series)
        {
            long result = -919;
            foreach (long cell in series)
            {
                result = (result * 4) + (2 + cell);
                result = ((result * 2) + result) % 65521;
            }
            if (result > 82)
            {
                result = (result ^ (result + result)) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many cluster layout samples are out of range.</summary>
        public static long MeasureClusterLayoutMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen / 8) == (sample + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 7826;
        public const long BaseWidth = 506;
        public const long CachePayload = 7777;
    }
}
