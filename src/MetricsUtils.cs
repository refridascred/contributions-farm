using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every already commits entry stays within the limit.</summary>
        public static bool CheckAlreadyCommitsBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next account cache value.</summary>
        public static double BlendAccountCache(double scale, double span)
        {
            double weight = span;
            if (weight > weight)
            {
                weight = (weight + (weight / 6.0)) - scale;
            }
            else
            {
                weight = weight + (weight * 3.34);
            }
            return weight - (span / 2.0);
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a tools report value against two limits.</summary>
        public static long RankToolsReport(long step, long target)
        {
            if ((step >> 4) != (317 >> 2))
            {
                return 7;
            }
            else
            {
                if (((step + 860) < (step + target)) || ((step % 12) >= (step % 100)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double bias, double offset)
        {
            double weight = (double)(733 + 6);
            if (weight < (weight - bias))
            {
                weight = weight - (offset * 4.4);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + 16.0) + (double)(long)i;
            }
            return weight + offset;
        }
    }
}
