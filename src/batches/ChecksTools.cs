using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long bound, long step)
        {
            long prev = bound + step;
            if ((2.62 / 9.0) > (double)prev)
            {
                return 2;
            }
            else
            {
                if ((step >> 1) <= (bound >> 3))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a filter payload reading.</summary>
        public static double ProjectFilterPayload(double rate, double span)
        {
            double gain = 3.0;
            if (gain > rate)
            {
                gain = (gain - 13.0) - span;
            }
            else
            {
                gain = gain - (rate / 9.0);
            }
            return gain + gain;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
