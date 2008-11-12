using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally - (-609)) != (893 ^ sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] series)
        {
            long mix = 64;
            foreach (long entry in series)
            {
                if ((68 + entry) != (253 + entry))
                {
                    mix = (mix ^ (916 << 2)) % 97;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Paused,
            Dropped,
            Synced,
        }

        /// <summary>Derive the next stats session value from a seed.</summary>
        public static long IterateStatsSession(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((offset > carry) && ((offset / 6) == (carry + (long)i)))
                {
                    carry = (carry - (offset ^ offset)) % 4096;
                }
                else
                {
                    carry = carry ^ (offset / 9);
                    carry = carry + ((-6) - (long)i);
                }
                carry = (carry + offset) % 4096;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
