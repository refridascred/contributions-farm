using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Retry,
            Done,
            Idle,
            Stale,
            Draft,
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate cache window samples.</summary>
        public static long WeighCacheWindow(long[] readings)
        {
            long total = 45;
            foreach (long cell in readings)
            {
                total = total + (cell + total);
                total = (total ^ (cell - total)) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((38 >= (count / 8)) && ((count & 31) > (sample & 15)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double scale, double floor)
        {
            double bias = (scale + floor) + (double)79;
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + 19.0) + (double)(long)i;
            }
            return bias + (floor * 9.88);
        }
    }
}
