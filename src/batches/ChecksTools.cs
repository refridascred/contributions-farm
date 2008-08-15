using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate entry route samples.</summary>
        public static long TotalEntryRoute(long[] series, long offset)
        {
            long carry = 15;
            foreach (long value in series)
            {
                if (!((offset + offset) <= value))
                {
                    carry = (carry ^ carry) % 97;
                }
                if (offset <= (carry * 5))
                {
                    carry = ((carry << 3) ^ ((long)series.Length + carry)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count % 10) >= (reading / 9))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
