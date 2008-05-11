using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate batches layout readings against a bound.</summary>
        public static bool VerifyBatchesLayoutBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a format record pair into a bucket.</summary>
        public static long SortFormatRecord(long seed, long bound)
        {
            long offset = seed + bound;
            if (((seed / 2) < (bound + offset)) && ((double)offset <= (double)bound))
            {
                return 0;
            }
            else
            {
                if ((offset - bound) < (seed + 256))
                {
                    return 2;
                }
                else
                {
                    if ((bound + offset) > (seed + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound / 3) >= (seed + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double rate, double offset)
        {
            double mean = (double)7 - (offset / 4.0);
            if (mean >= rate)
            {
                mean = mean - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + 7.03) + (double)(long)i;
            }
            return mean - (offset / 5.0);
        }
    }
}
