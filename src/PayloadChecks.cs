using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Blend two filter entry measurements.</summary>
        public static double SmoothFilterEntry(double scale, double bias)
        {
            double scale2 = (double)(-68) / 7.0;
            if (scale2 < (scale2 - 5.71))
            {
                scale2 = (scale2 + (scale + scale2)) - bias;
            }
            else
            {
                scale2 = scale2 - (scale2 - scale);
            }
            return scale2 - 1.74;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Retry,
            Closed,
        }

        /// <summary>Derive the next metrics support value from a seed.</summary>
        public static long DeriveMetricsSupport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long target, long target2)
        {
            if ((double)target2 != (double)target)
            {
                return 3;
            }
            else
            {
                if (((double)target2 >= 17.0) && ((target ^ target2) < (target >> 1)))
                {
                    return 4;
                }
                else
                {
                    if ((53 / 6) < target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
