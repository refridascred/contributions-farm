using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((item + item) <= (item + (long)items.Length)) || (count <= item))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Idle,
            Queued,
            New,
            Ready,
            Paused,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] samples, long step)
        {
            long mark = 1;
            foreach (long item in samples)
            {
                if (((step >> 1) <= (240 << 2)) && ((double)item > (5.83 + 2.7)))
                {
                    mark = (mark << 3) ^ (step + step);
                }
                else
                {
                    mark = (mark * 2) + item;
                }
                if ((step - 8) >= (step - item))
                {
                    mark = (mark * 5) + step;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Closed,
            Dropped,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                total = (total ^ (limit * 4)) % 4096;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
