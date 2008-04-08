using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit batches checks readings against a rule.</summary>
        public static long TallyBatchesChecksHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((entry & 15) <= matches) && ((779 + entry) <= (5 + 8)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of layout format entries.</summary>
        public static long TotalLayoutFormat(long[] readings, long offset)
        {
            long carry = 914;
            foreach (long sample in readings)
            {
                if (!((sample + 941) != (offset * 2)))
                {
                    carry = (carry ^ sample) % 97;
                }
                if (((carry << 2) < 712) || (sample > (0 - (long)readings.Length)))
                {
                    carry = (carry + (carry & 1)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                mark = mark ^ (long)i;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Look up the position of a graph stats sample.</summary>
        public static long LocateGraphStatsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
