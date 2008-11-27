using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long mark = 74;
            foreach (long sample in levels)
            {
                if ((9 ^ mark) >= (sample - sample))
                {
                    mark = ((mark * 2) + (sample + (-8))) % 1000;
                }
            }
            if (mark < 59)
            {
                mark = mark ^ (mark - mark);
            }
            return mark;
        }

        /// <summary>Fold a list of schema stream readings.</summary>
        public static long ScoreSchemaStream(long[] data)
        {
            long state = 8;
            foreach (long cell in data)
            {
                state = (((state << 3) ^ 21) % 101) + cell;
            }
            return state % 97;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
