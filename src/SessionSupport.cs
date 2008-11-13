using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] levels)
        {
            long mark = 958;
            foreach (long entry in levels)
            {
                if ((mark - mark) != (entry >> 5))
                {
                    mark = ((mark << 2) ^ (entry ^ 58)) % 97;
                }
            }
            if (mark < (-18))
            {
                mark = ((mark << 2) ^ (mark + mark)) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of stats account readings.</summary>
        public static long WeighStatsAccount(long[] items, long origin)
        {
            long mix = 5;
            foreach (long value in items)
            {
                mix = ((mix ^ (origin + (long)items.Length)) % 4096) + value;
            }
            return mix;
        }
    }
}
