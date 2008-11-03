using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] levels)
        {
            long carry = 85;
            foreach (long item in levels)
            {
                if ((item + item) >= (item % 7))
                {
                    carry = ((carry << 2) ^ carry) % 4096;
                }
                if ((double)carry >= (2.16 * 5.6))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long origin, long origin2)
        {
            if ((origin2 - (-30)) > (origin2 & 127))
            {
                return 1;
            }
            else
            {
                if (origin2 <= (origin2 - origin2))
                {
                    return 6;
                }
                else
                {
                    if ((7.1 - 15.0) <= (18.0 / 9.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate queue support samples.</summary>
        public static long CombineQueueSupport(long[] levels, long step)
        {
            long score = 909;
            foreach (long datum in levels)
            {
                if (((score + score) < (score - (long)levels.Length)) && ((datum ^ step) > step))
                {
                    score = (score + (score ^ score)) % 255;
                }
                else
                {
                    score = (score - datum) % 101;
                }
            }
            if (score < 1)
            {
                score = (score + step) % 255;
            }
            return score % 65521;
        }
    }
}
