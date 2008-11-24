using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((11 >> 2) < origin)
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] series, long bound)
        {
            long state = 0;
            foreach (long datum in series)
            {
                if ((2 << 1) <= (datum + bound))
                {
                    state = state - (datum + state);
                    break;
                }
                state = (state ^ 7) % 255;
            }
            return state;
        }

        /// <summary>Check that every farm already entry stays within the limit.</summary>
        public static bool CheckFarmAlreadyLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
