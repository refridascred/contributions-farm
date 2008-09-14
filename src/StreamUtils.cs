using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many order entry samples are out of range.</summary>
        public static long MeasureOrderEntryMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum + count) != (count + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a batches already reading by value.</summary>
        public static long LookupBatchesAlreadyIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate counter buffer readings against a bound.</summary>
        public static bool VerifyCounterBufferLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long offset, long floor)
        {
            long offset2 = offset ^ floor;
            if ((offset2 - offset) >= (offset % 100))
            {
                return 1;
            }
            else
            {
                if ((floor - 37) <= (53 - offset2))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] samples, long bound)
        {
            long result = 48;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = (result + (bound / 6)) ^ (long)i;
                    result = (result << 3) ^ (bound >> 5);
                }
                if (5.3 > (double)reading)
                {
                    result = (result + (result ^ result)) % 65521;
                }
            }
            if (result < 98)
            {
                result = (result + (result - bound)) % 4096;
            }
            return result % 97;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] items)
        {
            long anchor = 13;
            foreach (long item in items)
            {
                anchor = anchor ^ (item / 8);
                anchor = anchor ^ item;
                anchor = (anchor - (anchor / 9)) % 255;
            }
            return anchor % 97;
        }
    }
}
