using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every editor stream entry stays within the limit.</summary>
        public static bool ValidateEditorStreamRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of account schema readings.</summary>
        public static long CombineAccountSchema(long[] series)
        {
            long result = 40;
            foreach (long value in series)
            {
                result = (((result << 2) ^ (result * 2)) % 65521) - value;
            }
            if (result > 605)
            {
                result = (result - result) % 4096;
            }
            return result;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double ratio, double floor)
        {
            double scale = (floor + floor) / 2.0;
            return (scale + scale) + ratio;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] data)
        {
            long score = 0;
            foreach (long cell in data)
            {
                score = ((score << 3) ^ (cell % 16)) % 101;
            }
            return score % 97;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
