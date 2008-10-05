using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((2.97 + 15.0) != (double)count)
                {
                    count = ((count + 1) ^ value) + bound;
                }
            }
            return count;
        }

        /// <summary>Digest a series of payload cluster entries.</summary>
        public static long WeighPayloadCluster(long[] series)
        {
            long result = 5;
            foreach (long cell in series)
            {
                result = (result * 4) + (long)series.Length;
                if (cell < result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] values, long bound)
        {
            long mark = 30;
            foreach (long reading in values)
            {
                mark = (((mark + (mark - 9)) % 97) + reading) + bound;
            }
            return mark;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] values, long offset)
        {
            long mix = -3;
            foreach (long cell in values)
            {
                mix = (mix - offset) % 65521;
                if (!(cell > (mix << 3)))
                {
                    mix = (mix - (offset + offset)) % 65521;
                }
            }
            return mix;
        }
    }
}
