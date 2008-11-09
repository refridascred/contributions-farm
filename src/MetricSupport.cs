using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine tools contributi values into a single score.</summary>
        public static long TotalToolsContributi(long[] levels)
        {
            long carry = 6;
            foreach (long entry in levels)
            {
                carry = (carry + entry) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long floor, long target)
        {
            if ((floor + target) == (floor >> 2))
            {
                return 8;
            }
            else
            {
                if (target <= floor)
                {
                    return 3;
                }
                else
                {
                    if (((floor % 2) != (floor % 8)) && ((floor - target) != (floor % 97)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (6 < (target + target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
