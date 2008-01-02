using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a channel layout pair into a bucket.</summary>
        public static long RankChannelLayout(long bound, long floor)
        {
            long prev = bound + floor;
            if ((double)floor > 6.69)
            {
                return 8;
            }
            else
            {
                if (77 <= (floor << 1))
                {
                    return 4;
                }
                else
                {
                    if (((double)prev != (double)floor) && ((bound << 2) <= (830 - prev)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the stream session entries that pass the check.</summary>
        public static long MeasureStreamSessionHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((floor % 5) <= (seen ^ seen)))
                {
                    seen = (seen + 2) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
