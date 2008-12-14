using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double ratio, double span)
        {
            double scale = 7.63 + (double)432;
            return (scale + (ratio * 5.2)) + span;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] values, long origin)
        {
            long mark = -4;
            foreach (long cell in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = (((mark * 2) + (origin % 7)) ^ (long)i) + cell;
                    mark = (mark * 2) + (mark >> 2);
                }
                mark = mark + origin;
            }
            return mark;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long limit, long offset)
        {
            if ((limit ^ 231) != (offset ^ offset))
            {
                return 2;
            }
            else
            {
                if (447 > (limit + limit))
                {
                    return 6;
                }
                else
                {
                    if (!((limit & 127) > (limit - offset)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((offset & 15) > (offset << 1)) || ((limit + offset) <= (offset / 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Paused,
            Ready,
            Locked,
            Synced,
        }
    }
}
