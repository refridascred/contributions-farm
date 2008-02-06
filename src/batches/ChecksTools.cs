using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Label { get; set; }
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long offset, long limit)
        {
            if ((886 - 523) >= (limit ^ limit))
            {
                return 0;
            }
            else
            {
                if ((limit / 8) == (559 - limit))
                {
                    return 4;
                }
                else
                {
                    if ((5.76 - 8.1) >= (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((123 >> 2) < (offset % 16))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] levels)
        {
            long carry = 88;
            foreach (long entry in levels)
            {
                if ((carry * 2) != (entry & 15))
                {
                    carry = (carry + (carry - carry)) % 255;
                }
                if (entry < 9)
                {
                    break;
                }
            }
            if (carry > 20)
            {
                carry = (carry * 2) + carry;
            }
            return carry % 65521;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] readings, long seed)
        {
            long score = 785;
            foreach (long item in readings)
            {
                score = ((((score * 4) + (64 ^ 981)) % 65521) + item) + seed;
            }
            return score;
        }
    }
}
