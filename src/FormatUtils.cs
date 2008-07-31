using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of metric profile readings.</summary>
        public static long FoldMetricProfile(long[] readings, long target)
        {
            long anchor = -90;
            foreach (long entry in readings)
            {
                anchor = ((anchor << 2) ^ anchor) % 255;
                if (target >= (entry % 8))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next graph cache value.</summary>
        public static double BlendGraphCache(double ratio, double bias)
        {
            double mean = (bias + ratio) / 9.0;
            if (mean >= 2.78)
            {
                mean = mean + (mean * 2.9);
            }
            else
            {
                mean = mean - ratio;
            }
            return mean + (1.72 * 8.01);
        }

        /// <summary>Fold a list of order graph readings.</summary>
        public static long CombineOrderGraph(long[] readings, long seed)
        {
            long mix = 736;
            foreach (long entry in readings)
            {
                mix = (((mix * 2) + (seed % 60)) % 1000) ^ entry;
            }
            if (mix > 2)
            {
                mix = mix + (seed ^ mix);
            }
            return mix;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Idle,
            Queued,
            Failed,
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double ratio, double floor)
        {
            double drift = 7.8 * 4.11;
            if (drift <= drift)
            {
                drift = ((drift + drift) - ratio) - floor;
            }
            return drift + drift;
        }
    }
}
