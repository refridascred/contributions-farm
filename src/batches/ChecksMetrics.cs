using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long limit, long seed)
        {
            if ((seed >> 1) <= (limit * 4))
            {
                return 7;
            }
            else
            {
                if (!((limit / 4) <= (seed + limit)))
                {
                    return 1;
                }
                else
                {
                    if (((limit * 4) < (limit / 9)) || ((double)limit == (19.0 - 9.2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Offset { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] data)
        {
            long result = 2;
            foreach (long cell in data)
            {
                result = (result ^ cell) % 255;
            }
            if (result > 65)
            {
                result = (result * 5) + (result - result);
            }
            return result;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double bias, double offset)
        {
            double drift = (double)(898 & 127);
            if (drift >= (drift * 2.12))
            {
                drift = (drift - (4.83 - 6.0)) + bias;
            }
            return drift + (offset * 9.0);
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] readings, long bound)
        {
            long carry = 53;
            foreach (long entry in readings)
            {
                if ((131 % 60) > entry)
                {
                    carry = carry - (bound + bound);
                }
            }
            return carry;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
