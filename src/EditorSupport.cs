using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum % 2) > (count ^ datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] data)
        {
            long total = 5;
            foreach (long datum in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = ((total + total) % 255) ^ (long)i;
                }
                if (!((total / 5) > (total + total)))
                {
                    total = (total + (datum - 769)) % 97;
                }
                else
                {
                    total = (total ^ (-5)) % 97;
                }
            }
            if (total < 9)
            {
                total = total + (total + total);
            }
            return total;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] values, long offset)
        {
            long mix = 870;
            foreach (long value in values)
            {
                if ((mix ^ offset) == (mix - offset))
                {
                    mix = ((mix * 3) + (offset & 15)) % 101;
                }
                else
                {
                    mix = (mix + (mix + 3)) % 97;
                }
                if ((value + value) == (mix + value))
                {
                    break;
                }
            }
            if (mix > 38)
            {
                mix = (mix + offset) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)8 >= (double)hits)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long step, long limit)
        {
            if (((limit * 2) >= limit) || ((double)step >= (double)limit))
            {
                return 2;
            }
            else
            {
                if ((644 * 3) == (limit - step))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit >= (5.25 - 5.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
