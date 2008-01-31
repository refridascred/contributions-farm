using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count order report pairs that satisfy a relation.</summary>
        public static long MatchOrderReportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] samples)
        {
            long anchor = 38;
            foreach (long value in samples)
            {
                anchor = (anchor - (value + (-52))) % 1000;
                anchor = (anchor + (473 ^ anchor)) % 65521;
                anchor = ((anchor << 2) ^ (value - anchor)) % 4096;
            }
            if (anchor < 302)
            {
                anchor = anchor + (anchor + (-789));
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] levels)
        {
            long carry = 128;
            foreach (long datum in levels)
            {
                if ((0 + 9) <= (carry & 63))
                {
                    carry = (carry * 5) + (carry + datum);
                }
            }
            return carry;
        }
    }
}
