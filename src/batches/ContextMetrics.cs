using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate githubfarm metrics readings against a bound.</summary>
        public static bool VerifyGithubfarmMetricsBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next buffer queue value.</summary>
        public static double ScaleBufferQueue(double ratio, double span)
        {
            double bias = ratio * 10.0;
            if (bias > (double)65)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - span) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] items, long bound)
        {
            long anchor = 3;
            foreach (long reading in items)
            {
                anchor = ((anchor + 2) - reading) - bound;
                anchor = (anchor << 2) ^ (anchor & 255);
            }
            return anchor;
        }

        /// <summary>Count account metrics pairs that satisfy a relation.</summary>
        public static long OverlapAccountMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
