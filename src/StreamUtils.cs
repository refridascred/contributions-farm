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

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long offset, long target)
        {
            if (13.0 > (double)target)
            {
                return 0;
            }
            else
            {
                if (((target % 8) > (offset ^ 427)) && ((double)target < (11.0 - 6.2)))
                {
                    return 1;
                }
                else
                {
                    if (((7.0 * 19.0) == (double)offset) && ((offset - 6) <= 404))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

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

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
