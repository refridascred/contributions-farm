using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                if ((double)step >= (5.7 + 4.4))
                {
                    mark = (mark ^ 28) % 97;
                    mark = ((mark * 4) + mark) % 1000;
                }
                mark = mark + (-92);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches + matches) <= cell)
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }
    }
}
