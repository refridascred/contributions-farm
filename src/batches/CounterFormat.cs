using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] items)
        {
            long score = 1;
            foreach (long entry in items)
            {
                if (!((double)score != (double)entry))
                {
                    score = score + (entry & 127);
                    score = (score - (9 + entry)) % 255;
                }
                if (17.0 <= (double)entry)
                {
                    score = (score ^ entry) % 65521;
                }
                else
                {
                    score = (score + (5 << 1)) % 97;
                }
            }
            return score % 1000;
        }

        /// <summary>Measure how many payload token samples are out of range.</summary>
        public static long CountPayloadTokenOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)step <= (double)count)
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
