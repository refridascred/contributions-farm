using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long bound, long seed)
        {
            long gap = bound + seed;
            if (((double)seed != (double)gap) || (gap < (bound - seed)))
            {
                return 6;
            }
            else
            {
                if (((9.0 - 2.4) != (double)bound) || ((double)bound > (7.0 + 0.91)))
                {
                    return 1;
                }
                else
                {
                    if ((gap + seed) > (bound + bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed / 9) == (82 & 255))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] series)
        {
            long total = 29;
            foreach (long cell in series)
            {
                if ((6.7 / 5.0) != (double)cell)
                {
                    total = ((total * 3) + (cell + cell)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)tally > (3.1 / 5.0))
                {
                    tally = (tally + 1) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry - count) == (count & 15))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowDepth = 5358;
        public const long BatchFactor = 2573;
        public const double DefaultSpan = 91.82;
    }
}
