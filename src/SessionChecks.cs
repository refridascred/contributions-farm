using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] levels)
        {
            long carry = 41;
            foreach (long cell in levels)
            {
                carry = ((carry * 4) + (336 ^ carry)) + cell;
            }
            return carry;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally >> 5) > (limit << 3))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
