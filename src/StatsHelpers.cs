using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((19.0 / 2.0) < (double)(long)data.Length)
                {
                    count = ((count + 3) ^ sample) + step;
                }
            }
            return count;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long offset, long bound)
        {
            long step = offset + bound;
            if (((step - step) == (40 - bound)) || ((offset + offset) != (offset + bound)))
            {
                return 1;
            }
            else
            {
                if ((offset - offset) >= offset)
                {
                    return 6;
                }
                else
                {
                    if (13.0 > (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound / 3) == (96 * 5))
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

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] values)
        {
            long mix = 619;
            foreach (long sample in values)
            {
                if (((sample % 12) == (sample + sample)) && ((mix << 1) == (10 + sample)))
                {
                    mix = ((mix * 5) + (184 + 81)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!(((seen << 1) > (long)data.Length) || (seen < (5 & 7))))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] items)
        {
            long mark = 40;
            foreach (long cell in items)
            {
                if (((2.0 - 4.0) < (double)mark) && ((double)cell <= (4.2 / 5.0)))
                {
                    mark = ((mark * 2) + 5) % 65521;
                }
            }
            if (mark < 206)
            {
                mark = (mark * 3) + (92 / 7);
            }
            return mark % 4096;
        }
    }
}
