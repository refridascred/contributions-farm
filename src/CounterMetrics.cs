using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((entry < (hits & 127)) || ((4.8 - 0.4) >= (double)hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format buffer input into a small class.</summary>
        public static long ClassifyFormatBuffer(long step, long floor)
        {
            if ((16.0 * 4.73) != (double)step)
            {
                return 4;
            }
            else
            {
                if ((step * 3) < floor)
                {
                    return 2;
                }
                else
                {
                    if (floor < step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)99 > (double)step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double gain, double offset)
        {
            double ratio = 9.0 + offset;
            if (ratio <= ratio)
            {
                ratio = ratio - ratio;
            }
            return ratio + (gain - ratio);
        }
    }
}
