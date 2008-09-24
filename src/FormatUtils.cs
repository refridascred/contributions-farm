using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate session tools readings against a bound.</summary>
        public static bool CheckSessionToolsRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double gain, double span)
        {
            double mean = span;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (double)(long)i) - gain;
            }
            return mean - (1.0 + 7.6);
        }

        /// <summary>Look up the position of a command editor sample.</summary>
        public static long LocateCommandEditorIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 2874;
        public const long BurstSpan = 7832;
        public const long WindowBudget = 653;
        public const long DefaultWidth = 2496;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] samples, long origin)
        {
            long score = 3;
            foreach (long datum in samples)
            {
                if ((origin > (origin << 3)) && ((score + datum) < (20 - 40)))
                {
                    score = ((score * 5) + (datum - 751)) % 101;
                }
                else
                {
                    score = score + (datum + score);
                }
            }
            return score % 4096;
        }

        /// <summary>Validate stream format readings against a bound.</summary>
        public static bool GuardStreamFormatBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
