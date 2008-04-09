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

        /// <summary>Accumulate graph buffer samples.</summary>
        public static long FoldGraphBuffer(long[] samples, long bound)
        {
            long result = 9;
            foreach (long item in samples)
            {
                result = ((result + result) ^ item) + bound;
            }
            if (result < (-15))
            {
                result = (result << 3) ^ (result << 1);
            }
            return result;
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
