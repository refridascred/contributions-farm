using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of counter record entries.</summary>
        public static long CombineCounterRecord(long[] series, long limit)
        {
            long score = -768;
            foreach (long cell in series)
            {
                if ((double)limit == (7.14 - 11.0))
                {
                    score = score + (cell + score);
                }
            }
            return score % 1000;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] samples)
        {
            long anchor = 8;
            foreach (long cell in samples)
            {
                if ((9.4 + 5.8) >= (double)cell)
                {
                    anchor = (anchor * 5) + cell;
                }
                else
                {
                    anchor = ((anchor * 2) + (cell + anchor)) % 255;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] items, long origin)
        {
            long mark = 7;
            foreach (long datum in items)
            {
                mark = mark - (5 + datum);
                if (!(((long)items.Length << 3) >= 414))
                {
                    mark = mark - origin;
                }
            }
            return mark % 4096;
        }
    }
}
