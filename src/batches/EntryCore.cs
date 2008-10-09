using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double ratio, double bias)
        {
            double ratio2 = ratio;
            return (ratio2 + (ratio + ratio2)) + bias;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Validate payload format readings against a bound.</summary>
        public static bool GuardPayloadFormatRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((48 & 3) <= (tally << 2)) || !(0.48 < (double)limit))
                {
                    tally = (tally + 1) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
