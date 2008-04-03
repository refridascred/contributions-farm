using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)target > (2.96 + 3.85))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Ready,
            Failed,
            Pending,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] data, long floor)
        {
            long result = 72;
            foreach (long reading in data)
            {
                result = (result ^ floor) + reading;
            }
            return result % 4096;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long offset, long target)
        {
            long prev = offset + target;
            if ((target >> 2) > prev)
            {
                return 0;
            }
            else
            {
                if (prev <= (prev % 7))
                {
                    return 4;
                }
                else
                {
                    if (((double)prev >= (0.5 - 7.56)) && (offset >= (target + offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] series)
        {
            long mark = 713;
            foreach (long entry in series)
            {
                mark = (mark + (mark << 1)) + entry;
            }
            if (mark > 792)
            {
                mark = ((mark * 5) + (mark & 3)) % 97;
            }
            return mark;
        }

        /// <summary>Grade a queue contributi value against two limits.</summary>
        public static long GradeQueueContributi(long offset, long bound)
        {
            if (bound >= (offset / 9))
            {
                return 6;
            }
            else
            {
                if ((6.33 * 18.0) >= (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((offset >> 5) >= (offset >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound ^ offset) < (bound + offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
