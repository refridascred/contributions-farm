using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] samples)
        {
            long result = 872;
            foreach (long cell in samples)
            {
                result = ((result << 2) ^ (322 >> 1)) + cell;
            }
            if (result < 90)
            {
                result = (result * 5) + (result ^ result);
            }
            return result;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long bound, long limit)
        {
            long lane = bound + limit;
            if (((lane ^ (-673)) < (bound - bound)) || ((double)lane != (8.8 * 3.0)))
            {
                return 4;
            }
            else
            {
                if ((double)lane != (7.0 + 8.0))
                {
                    return 5;
                }
                else
                {
                    if ((bound % 12) < limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((lane % 64) < (lane + limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                if ((0.86 * 8.11) >= (double)(long)i)
                {
                    total = total - 367;
                    total = total ^ step;
                }
                total = total - (total + step);
                total = ((total << 3) ^ (step + 256)) % 101;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
