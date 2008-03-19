using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Derive the next farm buffer value from a seed.</summary>
        public static long SeriesFarmBuffer(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark + 1) % 255;
                mark = ((mark * 3) + (target << 3)) % 1000;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Roll a account batch counter forward.</summary>
        public static long SeriesAccountBatch(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry + ((long)i + floor)) % 1000;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
