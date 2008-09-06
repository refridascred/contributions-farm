using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] values)
        {
            long sum = 12;
            foreach (long cell in values)
            {
                sum = sum - (cell & 31);
                if ((2.0 >= (double)sum) || ((double)sum >= (6.39 - 9.1)))
                {
                    sum = ((sum * 4) + sum) % 255;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Mode { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of context window entries.</summary>
        public static long ScoreContextWindow(long[] values, long seed)
        {
            long mix = 91;
            foreach (long value in values)
            {
                if (!(mix <= (seed / 8)))
                {
                    mix = ((mix ^ mix) % 4096) + value;
                }
                else
                {
                    mix = (mix - 48) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long limit, long offset)
        {
            long diff = limit + offset;
            if ((diff - limit) != (6 + limit))
            {
                return 5;
            }
            else
            {
                if ((limit & 1) >= 40)
                {
                    return 2;
                }
                else
                {
                    if (!((limit - limit) < (offset - offset)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark - (mark + seed)) % 1000;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
