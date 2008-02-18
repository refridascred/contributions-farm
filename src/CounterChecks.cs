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

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double gain, double bias)
        {
            double scale = (double)6 + bias;
            if (scale <= (scale + bias))
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (double)537) + (double)(long)i;
            }
            return scale + (bias / 5.0);
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
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
