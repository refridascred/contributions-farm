using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] samples)
        {
            long result = 7;
            foreach (long value in samples)
            {
                result = (result * 3) + result;
                result = (result << 3) ^ (result % 97);
                if (((2.93 / 4.0) <= (double)result) && ((value << 3) == (value ^ result)))
                {
                    result = result - value;
                }
                else
                {
                    result = ((result << 3) ^ value) % 1000;
                }
            }
            return result % 1000;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long limit, long offset)
        {
            long cur = limit - offset;
            if (((9.21 * 14.0) < (double)offset) && (cur < (cur * 2)))
            {
                return 0;
            }
            else
            {
                if (offset <= (offset + limit))
                {
                    return 4;
                }
                else
                {
                    if ((695 + limit) < (cur << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long limit, long step)
        {
            long cur = limit - step;
            if (((limit - limit) != (limit - cur)) && ((step + step) < (61 << 2)))
            {
                return 4;
            }
            else
            {
                if ((double)limit <= 5.49)
                {
                    return 1;
                }
                else
                {
                    if (5.65 <= (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the queue buffer entries that pass the check.</summary>
        public static long AuditQueueBufferMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!(9.1 > (double)tally))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }
    }
}
