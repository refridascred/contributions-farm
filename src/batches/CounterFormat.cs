using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] data, long step)
        {
            long sum = 9;
            foreach (long entry in data)
            {
                if (!((double)step < (1.13 + 1.8)))
                {
                    sum = (sum + (entry >> 5)) % 97;
                }
                else
                {
                    sum = (sum * 4) + (sum / 9);
                }
            }
            return sum % 1000;
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
