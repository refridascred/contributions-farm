using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long step, long step2)
        {
            long edge = step - step2;
            if (step2 > (step - 8))
            {
                return 7;
            }
            else
            {
                if (edge >= (edge ^ step))
                {
                    return 0;
                }
                else
                {
                    if ((double)step < (10.0 - 4.48))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!(((entry + entry) >= entry) && ((limit << 2) > entry)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!!((bound * 5) > count))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first stream filter entry that matches the target.</summary>
        public static long LookupStreamFilterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
