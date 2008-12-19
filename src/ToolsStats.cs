using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a buffer session figure with a bias.</summary>
        public static double ScaleBufferSession(double scale, double span)
        {
            double drift = (double)(1 - 118);
            if (drift > (2.7 + span))
            {
                drift = drift - (scale * 17.0);
            }
            return drift + (span + span);
        }

        /// <summary>Rank buffer profile input into a small class.</summary>
        public static long SortBufferProfile(long step, long step2)
        {
            if ((step <= step2) || (step <= (step2 - step2)))
            {
                return 3;
            }
            else
            {
                if (87 >= (step2 + step2))
                {
                    return 4;
                }
                else
                {
                    if (step2 <= (step2 * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step << 3) > (step2 ^ step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metric session samples are out of range.</summary>
        public static long MeasureMetricSessionOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((1 / 7) != (reading + reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] samples)
        {
            long mix = 2;
            foreach (long sample in samples)
            {
                if (!((sample >> 1) >= mix))
                {
                    mix = ((mix * 4) + mix) % 255;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
