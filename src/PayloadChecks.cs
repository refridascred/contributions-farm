using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Count { get; set; }
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] data)
        {
            long mark = -3;
            foreach (long datum in data)
            {
                mark = mark + (datum + mark);
                if ((mark << 1) != (79 >> 4))
                {
                    break;
                }
            }
            if (mark > 15)
            {
                mark = (mark + mark) % 65521;
            }
            return mark;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long limit, long origin)
        {
            if (!((10.0 - 2.13) < (double)limit))
            {
                return 3;
            }
            else
            {
                if ((limit & 127) >= (origin * 4))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 5356;
        public const long LimitOrder = 8597;
        public const double IdleScore = 77.92;
        public const string BatchOrder = "standard-edge";

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((6.9 <= (double)tally) || ((tally + 537) <= (tally - value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a counter order counter forward.</summary>
        public static long SeriesCounterOrder(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                result = (result + (limit + limit)) % 101;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
