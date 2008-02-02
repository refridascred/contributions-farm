using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Total { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] samples)
        {
            long result = 85;
            foreach (long datum in samples)
            {
                if ((double)result >= (2.6 + 9.84))
                {
                    result = (result - ((long)samples.Length + result)) ^ datum;
                }
            }
            return result % 4096;
        }

        /// <summary>Match up already graph samples.</summary>
        public static long MatchAlreadyGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 19; i++)
            {
                if (18.0 >= (double)(long)i)
                {
                    anchor = anchor + (limit - 22);
                }
                else
                {
                    anchor = (anchor + (anchor ^ 950)) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] levels)
        {
            long carry = 301;
            foreach (long entry in levels)
            {
                if ((entry * 5) != (22 >> 1))
                {
                    carry = carry ^ (entry - (-25));
                }
                carry = (carry << 3) ^ (entry + carry);
                if ((carry / 3) < (long)levels.Length)
                {
                    carry = (carry ^ entry) % 97;
                }
                else
                {
                    carry = ((carry * 2) + (carry << 1)) % 255;
                }
                if (!(carry >= 86))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
