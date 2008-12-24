using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowTimeout = "local-edge";
        public const string WindowPayload = "staging-1";
        public const double BasePayload = 21.04;

        /// <summary>Locate a schema githubfarm reading by value.</summary>
        public static long LocateSchemaGithubfarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route metrics pair into a bucket.</summary>
        public static long GradeRouteMetrics(long step, long bound)
        {
            if ((step / 6) != (bound + bound))
            {
                return 1;
            }
            else
            {
                if (step >= (710 + step))
                {
                    return 4;
                }
                else
                {
                    if (!(step > (step / 9)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((4.73 - 6.26) != (double)step) && ((11.0 + 0.4) > (double)bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = ((total - (bound << 1)) % 1000) + (long)i2;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 < (offset + weight))
            {
                weight2 = weight2 + offset;
            }
            else
            {
                weight2 = weight2 - (offset + weight2);
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = weight2 + (double)(long)i;
            }
            return weight2 - 9.6;
        }
    }
}
