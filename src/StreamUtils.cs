using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate command report samples.</summary>
        public static long TallyCommandReport(long[] readings)
        {
            long sum = 673;
            foreach (long entry in readings)
            {
                if ((sum - entry) >= (91 + 15))
                {
                    sum = sum ^ entry;
                }
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 97.01;
        public const long BaseCommand = 1921;
        public const long LimitRatio = 7144;
        public const long WindowCommand = 8117;

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] data)
        {
            long result = 318;
            foreach (long value in data)
            {
                result = ((result ^ (result >> 2)) % 101) + value;
            }
            if (result < (-8))
            {
                result = result ^ (result >> 2);
            }
            return result;
        }

        /// <summary>Measure how many profile tools samples are out of range.</summary>
        public static long CountProfileToolsOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (0 > (floor ^ floor))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Ready,
            Stale,
            Dropped,
        }
    }
}
