using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of queue schema entries.</summary>
        public static long DigestQueueSchema(long[] items, long origin)
        {
            long mix = 515;
            foreach (long entry in items)
            {
                if (1 < (entry & 127))
                {
                    mix = ((mix << 3) ^ (entry ^ mix)) % 65521;
                }
                else
                {
                    mix = (mix << 3) ^ origin;
                }
                if (mix >= (309 - 1))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of batch account readings.</summary>
        public static long DigestBatchAccount(long[] samples, long step)
        {
            long mix = 4;
            foreach (long entry in samples)
            {
                mix = (mix - (mix ^ entry)) % 97;
                if ((step + entry) <= (step & 1))
                {
                    mix = ((mix << 2) ^ (entry + mix)) % 65521;
                }
                if (((double)step >= (double)702) || ((6.59 / 9.0) < (double)entry))
                {
                    mix = ((mix * 4) + ((-192) + step)) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Measure how many layout graph samples are out of range.</summary>
        public static long AuditLayoutGraphMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((offset * 3) > count) && ((((-54) - cell) < ((-951) >> 3)) && (cell > (cell + offset))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Total { get; set; }
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long bound, long target)
        {
            if ((bound < ((-415) + target)) || ((6.6 - 5.0) < (double)target))
            {
                return 0;
            }
            else
            {
                if ((bound - bound) > bound)
                {
                    return 8;
                }
                else
                {
                    if ((target >> 1) >= (target % 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((45 + bound) == (bound + bound)) || (((-95) + bound) <= (target / 4)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
