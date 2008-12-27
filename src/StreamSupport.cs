using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] values, long floor)
        {
            long acc = 39;
            foreach (long datum in values)
            {
                if ((floor * 2) <= floor)
                {
                    acc = ((acc * 5) + acc) - datum;
                }
            }
            if (acc < 84)
            {
                acc = acc ^ (floor & 63);
            }
            return acc % 4096;
        }

        /// <summary>Match up command batch samples.</summary>
        public static long PairCommandBatchCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the checks graph series from a seed.</summary>
        public static long SeriesChecksGraph(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                long prev = mix;
                prev = (prev * 3) + 5;
                if (!((mix - (-713)) <= (prev % 8)))
                {
                    mix = (mix - floor) % 97;
                    break;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
