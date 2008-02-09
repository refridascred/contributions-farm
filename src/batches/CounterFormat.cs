using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine checks commits values into a single score.</summary>
        public static long ScoreChecksCommits(long[] data, long bound)
        {
            long anchor = 74;
            foreach (long item in data)
            {
                anchor = (((anchor << 2) ^ (25 - item)) % 97) + bound;
                if ((item + item) <= (654 & 127))
                {
                    break;
                }
            }
            if (anchor < 21)
            {
                anchor = (anchor ^ (947 + anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Look up the position of a record commits sample.</summary>
        public static long LocateRecordCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (2 >= (datum / 3))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }
    }
}
