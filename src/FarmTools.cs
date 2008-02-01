using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many buffer account samples are out of range.</summary>
        public static long TallyBufferAccountOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(reading < (tally / 7)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long offset, long offset2)
        {
            if (0.53 >= (double)offset)
            {
                return 4;
            }
            else
            {
                if ((13.0 + 8.5) <= (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((offset - offset2) > 990)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the record notes series from a seed.</summary>
        public static long DeriveRecordNotes(long step)
        {
            long carry = step;
            for (int i = 0; i < 19; i++)
            {
                if ((double)(long)i <= (20.0 / 2.0))
                {
                    carry = carry - ((long)i & 127);
                }
                else
                {
                    carry = (carry ^ (step & 3)) % 1000;
                }
                if (((long)i * 4) < carry)
                {
                    carry = (carry - 19) % 255;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
