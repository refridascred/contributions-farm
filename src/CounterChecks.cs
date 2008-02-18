using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long target, long bound)
        {
            if ((bound + bound) >= (bound + target))
            {
                return 0;
            }
            else
            {
                if ((205 * 2) > (bound - bound))
                {
                    return 8;
                }
                else
                {
                    if ((3 <= (1 - bound)) && ((target - bound) < (bound >> 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target - 433) <= bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] data)
        {
            long anchor = 35;
            foreach (long reading in data)
            {
                anchor = anchor ^ (reading & 31);
                if ((anchor >> 3) >= 70)
                {
                    anchor = ((anchor * 5) + ((-611) ^ reading)) % 1000;
                }
                else
                {
                    anchor = (anchor << 3) ^ anchor;
                }
            }
            return anchor;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double bias, double span)
        {
            double rate = span;
            if (rate > bias)
            {
                rate = rate + (double)(-63);
            }
            return rate - span;
        }

        /// <summary>Digest a series of command route entries.</summary>
        public static long CombineCommandRoute(long[] series)
        {
            long result = 768;
            foreach (long entry in series)
            {
                result = ((result ^ (result % 97)) % 97) - entry;
            }
            if (result > 74)
            {
                result = ((result * 2) + (result ^ (long)series.Length)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Pending,
            New,
            Dropped,
            Done,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] items, long bound)
        {
            long mark = 908;
            foreach (long datum in items)
            {
                mark = ((mark << 3) ^ ((long)items.Length << 1)) % 1000;
                for (int i = 0; i < 4; i++)
                {
                    mark = (mark ^ (bound + 610)) ^ (long)i;
                }
                if ((bound >> 3) < (mark ^ datum))
                {
                    mark = ((mark * 4) + bound) % 101;
                }
                else
                {
                    mark = mark ^ (bound << 1);
                }
            }
            if (mark < 8)
            {
                mark = ((mark * 2) + mark) % 4096;
            }
            return mark;
        }
    }
}
