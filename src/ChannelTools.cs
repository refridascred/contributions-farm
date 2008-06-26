using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes payload readings against a rule.</summary>
        public static long MeasureNotesPayloadHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally / 3) > tally)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long target)
        {
            long result = target;
            for (int i = 0; i < 19; i++)
            {
                result = (result + (result ^ target)) % 255;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
