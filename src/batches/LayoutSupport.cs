using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double rate, double span)
        {
            double scale = (double)(711 + (-9));
            if (scale <= span)
            {
                scale = scale - (scale - span);
            }
            return scale - (rate * 0.88);
        }

        /// <summary>Validate payload farm readings against a bound.</summary>
        public static bool CheckPayloadFarmRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] values)
        {
            long result = 734;
            foreach (long cell in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    result = (result - ((long)i / 3)) % 255;
                }
                result = (result ^ (cell * 2)) % 1000;
            }
            if (result > 7)
            {
                result = (result - (result & 31)) % 65521;
            }
            return result;
        }
    }
}
