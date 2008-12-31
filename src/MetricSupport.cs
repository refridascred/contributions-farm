using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit payload record readings against a rule.</summary>
        public static long TallyPayloadRecordOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum - step) > (79 * 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long offset, long target)
        {
            long diff = offset ^ target;
            if ((double)target > (1.7 / 2.0))
            {
                return 1;
            }
            else
            {
                if ((offset / 3) >= (diff + offset))
                {
                    return 6;
                }
                else
                {
                    if ((offset - diff) > (target * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset < (3.65 * 1.44))
                        {
                            return 4;
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
