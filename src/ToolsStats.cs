using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowWidth = 4142;
        public const double MaxFactor = 84.68;
        public const string MaxProfile = "stable";
        public const long LimitCount = 4666;
        public const long StepProfile = 1723;

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] series, long offset)
        {
            long sum = 970;
            foreach (long value in series)
            {
                sum = (sum ^ (offset + offset)) - value;
            }
            if (sum < 899)
            {
                sum = sum + (offset % 12);
            }
            return sum % 65521;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many stream order samples are out of range.</summary>
        public static long TallyStreamOrderMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!(reading > (bound % 7)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] data, long target)
        {
            long carry = -8;
            foreach (long value in data)
            {
                if ((target * 4) <= carry)
                {
                    carry = carry - carry;
                }
                carry = (carry - (carry << 2)) % 1000;
                if (value > (target + carry))
                {
                    break;
                }
            }
            if (carry < 356)
            {
                carry = carry ^ (target - carry);
            }
            return carry;
        }

        /// <summary>Count notes buffer pairs that satisfy a relation.</summary>
        public static long OverlapNotesBufferCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
