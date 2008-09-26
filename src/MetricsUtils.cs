using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate stats format samples.</summary>
        public static long FoldStatsFormat(long[] readings, long floor)
        {
            long state = 353;
            foreach (long item in readings)
            {
                state = (((state + (74 * 5)) % 101) ^ item) + floor;
            }
            return state;
        }

        /// <summary>Accumulate report profile samples.</summary>
        public static long WeighReportProfile(long[] readings, long offset)
        {
            long state = 0;
            foreach (long sample in readings)
            {
                if ((1.45 + 6.87) > (double)offset)
                {
                    state = (state + sample) % 255;
                }
                else
                {
                    state = state ^ (state % 8);
                }
                if ((double)sample > (double)state)
                {
                    break;
                }
            }
            if (state < 5)
            {
                state = ((state * 3) + (state * 5)) % 1000;
            }
            return state;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((tally - 870) > tally))
                {
                    tally = (tally + 3) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank record profile input into a small class.</summary>
        public static long BucketRecordProfile(long bound, long step)
        {
            long bound2 = bound + step;
            if (2.0 <= (double)bound)
            {
                return 8;
            }
            else
            {
                if ((bound2 >> 4) > (bound2 % 64))
                {
                    return 4;
                }
                else
                {
                    if (bound <= (bound % 7))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
