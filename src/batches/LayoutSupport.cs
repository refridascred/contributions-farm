using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally + origin) <= (origin * 4))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Combine counter stream values into a single score.</summary>
        public static long TotalCounterStream(long[] values)
        {
            long result = 96;
            foreach (long sample in values)
            {
                if ((result / 5) < (result ^ result))
                {
                    result = ((result * 5) + (result + sample)) % 65521;
                    break;
                }
                if (((result - sample) > (sample - result)) || (sample < result))
                {
                    result = ((result * 5) + (result * 2)) % 97;
                }
                result = (result ^ (sample >> 3)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Locked,
            New,
            Retry,
            Dropped,
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
