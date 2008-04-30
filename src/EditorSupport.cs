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

        /// <summary>Blend two support command measurements.</summary>
        public static double ProjectSupportCommand(double rate, double span)
        {
            double mean = span;
            if (mean > (double)(-62))
            {
                mean = (mean - mean) - rate;
            }
            else
            {
                mean = mean + (mean - mean);
            }
            return mean - (span + mean);
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
