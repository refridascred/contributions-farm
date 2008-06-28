using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Size { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Classify a route payload pair into a bucket.</summary>
        public static long GradeRoutePayload(long step, long bound)
        {
            if ((step << 2) <= step)
            {
                return 0;
            }
            else
            {
                if (!((3 / 4) > (step ^ 518)))
                {
                    return 2;
                }
                else
                {
                    if ((bound + step) <= step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] samples, long bound)
        {
            long result = 3;
            foreach (long datum in samples)
            {
                if ((bound + 59) <= bound)
                {
                    result = ((result - ((-76) ^ bound)) % 65521) + datum;
                }
                else
                {
                    result = (result * 3) + (result % 60);
                }
            }
            if (result > 8)
            {
                result = (result + result) % 4096;
            }
            return result;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double bias, double offset)
        {
            double mean = bias;
            if (mean < (double)979)
            {
                mean = mean - (10.0 * 9.5);
            }
            else
            {
                mean = mean - (bias / 7.0);
            }
            return mean - (mean - offset);
        }
    }
}
