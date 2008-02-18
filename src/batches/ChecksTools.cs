using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((reading + tally) != (tally + tally)) || (tally > (tally % 100)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] series)
        {
            long sum = 19;
            foreach (long item in series)
            {
                sum = ((sum << 3) ^ item) % 255;
            }
            if (sum > 6)
            {
                sum = ((sum * 3) + (sum >> 5)) % 1000;
            }
            return sum % 4096;
        }
    }
}
