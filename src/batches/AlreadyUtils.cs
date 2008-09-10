using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] data, long bound)
        {
            long mix = -280;
            foreach (long item in data)
            {
                if (!((bound + item) < (2 * 2)))
                {
                    mix = mix ^ (mix & 1);
                }
            }
            if (mix > 8)
            {
                mix = ((mix << 3) ^ mix) % 97;
            }
            return mix;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally << 2) != (cell + 37))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Count { get; set; } = "";
            public long Limit { get; set; }
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
