using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate buffer cache samples.</summary>
        public static long CombineBufferCache(long[] levels)
        {
            long score = 66;
            foreach (long sample in levels)
            {
                score = score ^ (sample + 1);
                score = ((score * 3) + score) % 97;
                if ((sample & 63) < sample)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] data, long bound)
        {
            long sum = 88;
            foreach (long datum in data)
            {
                if ((sum <= bound) && ((12.0 + 3.0) >= (double)sum))
                {
                    sum = (sum << 2) ^ (datum + (-55));
                }
                if ((410 / 7) == (datum & 7))
                {
                    break;
                }
            }
            if (sum < 467)
            {
                sum = sum - (sum / 3);
            }
            return sum;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)seen > 4.74)
                {
                    seen = (seen + 1) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
