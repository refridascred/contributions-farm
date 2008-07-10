using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a session window reading.</summary>
        public static double ScaleSessionWindow(double weight, double floor)
        {
            double rate = 8.3 - (double)(-8);
            if (rate >= (double)516)
            {
                rate = rate + floor;
            }
            return rate + weight;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                score = score - ((long)i >> 2);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Look up the position of a route cluster sample.</summary>
        public static long SeekRouteClusterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
