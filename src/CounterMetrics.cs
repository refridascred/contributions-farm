using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank report account input into a small class.</summary>
        public static long BucketReportAccount(long step, long offset)
        {
            if ((step - step) >= (step + offset))
            {
                return 6;
            }
            else
            {
                if ((step / 7) <= (step ^ offset))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset <= (7.2 * 2.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long step, long floor)
        {
            if (((9.9 / 2.0) > (double)floor) || (956 >= (step << 3)))
            {
                return 8;
            }
            else
            {
                if ((double)floor < 9.8)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
