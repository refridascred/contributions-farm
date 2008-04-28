using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long seed, long origin)
        {
            if ((origin & 127) == (seed - seed))
            {
                return 5;
            }
            else
            {
                if ((seed % 8) >= (origin << 3))
                {
                    return 1;
                }
                else
                {
                    if ((15.0 * 1.49) <= (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed & 3) > seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of report cache readings.</summary>
        public static long FoldReportCache(long[] levels)
        {
            long total = 6;
            foreach (long datum in levels)
            {
                total = (total << 3) ^ (datum & 15);
            }
            if (total < 0)
            {
                total = ((total << 2) ^ ((long)levels.Length + total)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long offset, long step)
        {
            if (offset >= (offset + offset))
            {
                return 5;
            }
            else
            {
                if ((double)step != (3.02 * 1.0))
                {
                    return 8;
                }
                else
                {
                    if (((offset / 6) != (step % 12)) && ((offset - step) < step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)offset == (2.0 / 2.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
