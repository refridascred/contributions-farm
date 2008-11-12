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

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long floor, long offset)
        {
            long step = floor ^ offset;
            if (84 >= step)
            {
                return 7;
            }
            else
            {
                if ((step ^ offset) > (28 * 4))
                {
                    return 2;
                }
                else
                {
                    if (1.0 <= (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor + (-6)) <= (4 - (-388)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
