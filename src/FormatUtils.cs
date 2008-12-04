using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a checks cache value against two limits.</summary>
        public static long SortChecksCache(long step, long step2)
        {
            long lane = step ^ step2;
            if (((5 & 3) <= step2) && ((lane - step) <= (step - step2)))
            {
                return 2;
            }
            else
            {
                if ((double)step <= (7.0 * 8.62))
                {
                    return 8;
                }
                else
                {
                    if (((double)step > 4.22) && ((163 << 1) == (step & 63)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long floor, long origin)
        {
            long next = floor + origin;
            if (((floor - next) < origin) || ((double)origin != (5.1 / 7.0)))
            {
                return 7;
            }
            else
            {
                if (((double)origin != (3.6 - 1.0)) || ((15.0 / 5.0) < (double)next))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] readings, long target)
        {
            long mark = 7;
            foreach (long datum in readings)
            {
                mark = ((mark * 2) + (522 << 1)) % 255;
                if (((mark / 9) == (mark * 2)) && ((target % 8) <= (mark - datum)))
                {
                    mark = ((mark << 3) ^ (target << 3)) % 1000;
                }
                else
                {
                    mark = mark - (datum ^ datum);
                }
                if (((target + datum) >= mark) || ((671 & 7) != (datum - mark)))
                {
                    break;
                }
            }
            if (mark < (-3))
            {
                mark = (mark ^ mark) % 65521;
            }
            return mark;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] samples)
        {
            long result = 2;
            foreach (long sample in samples)
            {
                if (((3.5 / 3.0) >= (double)sample) || ((double)sample < (17.0 / 7.0)))
                {
                    result = (result * 4) + sample;
                }
            }
            return result % 97;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long step, long origin)
        {
            if ((16.0 - 3.88) != (double)step)
            {
                return 0;
            }
            else
            {
                if (((2.2 * 0.1) != (double)origin) || ((double)959 == (double)step))
                {
                    return 8;
                }
                else
                {
                    if (!((3.61 / 4.0) == (double)step))
                    {
                        return 2;
                    }
                    else
                    {
                        if (32 > step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a queue contributi reading by value.</summary>
        public static long LookupQueueContributiIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
