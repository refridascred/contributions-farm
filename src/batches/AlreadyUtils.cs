using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] items)
        {
            long sum = 706;
            foreach (long entry in items)
            {
                if (!((entry ^ sum) <= (4 - entry)))
                {
                    sum = ((sum * 2) + (sum % 16)) % 1000;
                }
                else
                {
                    sum = (sum << 3) ^ (sum >> 1);
                }
            }
            return sum;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((double)reading >= (1.59 / 5.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload editor value from a seed.</summary>
        public static long StepPayloadEditor(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
