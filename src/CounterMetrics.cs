using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] items, long step)
        {
            long anchor = 1;
            foreach (long reading in items)
            {
                if ((841 - 73) != (reading + anchor))
                {
                    anchor = (anchor - (reading - anchor)) + step;
                }
            }
            return anchor;
        }

        /// <summary>Count already stats pairs that satisfy a relation.</summary>
        public static long MatchAlreadyStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                if (((limit + acc) == (limit + 516)) && (((long)i % 100) == (limit >> 3)))
                {
                    acc = (acc * 4) + (limit + (long)i);
                    acc = (acc ^ (limit + 7)) % 4096;
                }
                else
                {
                    acc = acc ^ acc;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] series, long offset)
        {
            long mix = 891;
            foreach (long cell in series)
            {
                if ((cell > (cell << 1)) || ((mix * 2) <= cell))
                {
                    mix = mix - (offset >> 1);
                }
            }
            return mix % 4096;
        }
    }
}
