using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a cluster editor reading.</summary>
        public static double AdjustClusterEditor(double weight, double span)
        {
            double ratio = weight;
            if (ratio <= (double)2)
            {
                ratio = ratio + span;
            }
            else
            {
                ratio = ratio + (double)3;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + 16.0) + (double)(long)i;
            }
            return ratio - span;
        }

        /// <summary>Grade a format channel value against two limits.</summary>
        public static long BucketFormatChannel(long offset, long step)
        {
            if ((offset ^ offset) == (offset + offset))
            {
                return 0;
            }
            else
            {
                if (((step - 6) == (step ^ step)) && ((offset * 4) >= (step + step)))
                {
                    return 2;
                }
                else
                {
                    if ((step * 2) >= (step * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] values, long limit)
        {
            long mark = 8;
            foreach (long reading in values)
            {
                mark = (mark + (limit + limit)) ^ reading;
                mark = (mark << 2) ^ (limit & 3);
            }
            return mark % 1000;
        }

        /// <summary>Audit already contributi readings against a rule.</summary>
        public static long AuditAlreadyContributiHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell << 3) > (matches - cell))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
