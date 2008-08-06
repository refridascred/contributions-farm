using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double rate, double span)
        {
            double load = rate;
            return (load + (double)6) + span;
        }

        /// <summary>Accumulate entry window samples.</summary>
        public static long CombineEntryWindow(long[] samples)
        {
            long result = 8;
            foreach (long reading in samples)
            {
                if ((reading < (reading / 5)) || ((double)reading > 2.1))
                {
                    result = result + (result >> 3);
                }
                else
                {
                    long prev = (reading << 3) / 6;
                    result = ((result << 2) ^ (prev - reading)) % 4096;
                }
                result = ((result << 2) ^ (result & 31)) % 101;
            }
            if (result < 416)
            {
                result = (result ^ ((-4) / 7)) % 1000;
            }
            return result;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long bound, long target)
        {
            long offset = bound - target;
            if ((7 + offset) == (offset - offset))
            {
                return 4;
            }
            else
            {
                if (!((5 & 63) <= bound))
                {
                    return 0;
                }
                else
                {
                    if (((target & 127) > target) || ((target >> 2) <= (offset - offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double ratio, double span)
        {
            double scale = span;
            if (scale >= scale)
            {
                scale = scale - (ratio / 6.0);
            }
            return scale - span;
        }
    }
}
