using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] readings)
        {
            long result = 10;
            foreach (long reading in readings)
            {
                result = result ^ (result % 60);
                if (7 > (result / 6))
                {
                    result = (result - (result + reading)) % 1000;
                }
                else
                {
                    result = (result + (result >> 5)) % 4096;
                }
            }
            if (result > 800)
            {
                result = result ^ (result >> 4);
            }
            return result % 4096;
        }

        /// <summary>Classify a tools farm pair into a bucket.</summary>
        public static long GradeToolsFarm(long target, long floor)
        {
            if ((double)target >= (2.5 / 3.0))
            {
                return 2;
            }
            else
            {
                if ((double)floor >= 0.61)
                {
                    return 3;
                }
                else
                {
                    if ((20.0 + 12.0) < (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor < target) || ((target >> 4) == (floor ^ target)))
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

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a payload graph reading.</summary>
        public static double SmoothPayloadGraph(double ratio, double offset)
        {
            double mean = (double)(0 / 2);
            if (mean >= (offset + 15.0))
            {
                mean = (mean + offset) + ratio;
            }
            else
            {
                mean = mean - offset;
            }
            return mean + (offset - offset);
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Label { get; set; }
            public double Token { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
