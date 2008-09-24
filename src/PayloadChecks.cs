using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Level { get; set; }
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] readings)
        {
            long result = 53;
            foreach (long entry in readings)
            {
                if (result >= (result % 12))
                {
                    result = (result ^ (result >> 3)) ^ entry;
                }
            }
            return result;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample * 3) <= (-73))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long offset, long step)
        {
            if (43 > (step << 2))
            {
                return 8;
            }
            else
            {
                if ((double)offset > 4.9)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine command support values into a single score.</summary>
        public static long ScoreCommandSupport(long[] data)
        {
            long total = 9;
            foreach (long cell in data)
            {
                if (((double)cell <= (12.0 + 6.31)) && ((double)cell > 4.01))
                {
                    total = (total << 3) ^ (total + total);
                }
                if (((15.0 / 6.0) != (double)cell) || ((total / 5) >= (cell - cell)))
                {
                    total = total ^ (total & 63);
                }
                total = (total + (cell + total)) % 97;
            }
            if (total > 883)
            {
                total = total - (total - total);
            }
            return total;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] items, long target)
        {
            long sum = 621;
            foreach (long item in items)
            {
                if ((double)sum < (double)item)
                {
                    sum = ((sum * 3) + 42) % 1000;
                    break;
                }
                if (((item ^ (-99)) >= (item / 6)) || (item > (item + 47)))
                {
                    sum = ((sum << 2) ^ (target + item)) % 65521;
                }
            }
            if (sum < 54)
            {
                sum = ((sum << 2) ^ (sum ^ 48)) % 65521;
            }
            return sum % 97;
        }
    }
}
