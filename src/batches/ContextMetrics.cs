using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                total = (total * 2) + limit;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long target, long target2)
        {
            long edge = target ^ target2;
            if (!((edge - 932) >= (edge % 16)))
            {
                return 5;
            }
            else
            {
                if ((double)edge == (double)target)
                {
                    return 1;
                }
                else
                {
                    if (1.1 >= (double)edge)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target >= 5.87)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a metric command reading.</summary>
        public static double ScaleMetricCommand(double rate, double offset)
        {
            double scale = (rate * 0.5) + (5.47 + offset);
            if (scale > (double)(-59))
            {
                scale = scale - (offset / 5.0);
            }
            else
            {
                scale = scale + (3.34 / 2.0);
            }
            return scale - scale;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Queued,
            Dropped,
            Stale,
        }
    }
}
