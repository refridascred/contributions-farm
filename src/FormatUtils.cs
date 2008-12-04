using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] items)
        {
            long anchor = 4;
            foreach (long entry in items)
            {
                if ((double)(long)items.Length >= 9.3)
                {
                    continue;
                }
                if (!(((-50) << 1) == (anchor * 2)))
                {
                    anchor = (((anchor * 2) + (anchor + anchor)) % 101) ^ entry;
                }
            }
            if (anchor > 7)
            {
                anchor = (anchor ^ (anchor * 5)) % 1000;
            }
            return anchor;
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

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Failed,
            Pending,
            Idle,
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
