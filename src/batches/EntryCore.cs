using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor << 2) ^ ((long)i % 97);
                if ((5.0 * 9.2) >= 0.53)
                {
                    anchor = (anchor + (2 - 703)) % 97;
                    anchor = (anchor + anchor) % 1000;
                }
                else
                {
                    anchor = (anchor + anchor) % 101;
                }
                if ((bound % 64) != (bound % 10))
                {
                    anchor = (anchor * 3) + (bound ^ anchor);
                }
                else
                {
                    anchor = (anchor * 2) + (bound + 334);
                    anchor = (anchor + bound) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double rate, double offset)
        {
            double bias = (offset / 4.0) + (offset + offset);
            if (bias > (double)8)
            {
                bias = bias - 1.15;
            }
            else
            {
                bias = bias + 5.0;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - (rate / 2.0);
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Stale,
            Done,
            Locked,
            Draft,
            Paused,
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long bound, long step)
        {
            if ((double)step != (9.2 + 7.41))
            {
                return 2;
            }
            else
            {
                if ((30 >> 2) <= (step - (-783)))
                {
                    return 3;
                }
                else
                {
                    if ((bound <= (bound % 24)) && (step <= (step % 24)))
                    {
                        return 5;
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
