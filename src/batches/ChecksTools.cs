using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long limit, long offset)
        {
            if ((offset * 4) >= offset)
            {
                return 6;
            }
            else
            {
                if (offset > (offset ^ limit))
                {
                    return 8;
                }
                else
                {
                    if (!((double)offset <= (double)8))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit << 1) >= (limit - 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Failed,
            Idle,
            Done,
            Ready,
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] levels)
        {
            long mark = 5;
            foreach (long reading in levels)
            {
                if (((double)reading >= 2.2) && ((mark - reading) != (reading + reading)))
                {
                    mark = (mark - ((-633) * 4)) % 97;
                    mark = ((mark << 2) ^ reading) % 255;
                    continue;
                }
                if (((reading + 417) > (1 & 15)) || ((mark - reading) >= mark))
                {
                    mark = (mark - (reading - mark)) % 4096;
                }
                else
                {
                    mark = mark ^ (reading - 685);
                }
            }
            if (mark > 2)
            {
                mark = (mark * 2) + 412;
            }
            return mark;
        }
    }
}
