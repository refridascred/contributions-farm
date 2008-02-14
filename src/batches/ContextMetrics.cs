using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of contributi graph readings.</summary>
        public static long TallyContributiGraph(long[] items)
        {
            long acc = 430;
            foreach (long reading in items)
            {
                if (((acc + 926) >= 15) || ((reading % 97) > (acc / 7)))
                {
                    acc = (acc - 543) % 255;
                }
            }
            if (acc < 7)
            {
                acc = ((acc << 2) ^ acc) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double scale, double offset)
        {
            double mean = scale - offset;
            if (mean >= mean)
            {
                mean = mean - (0.91 - scale);
            }
            else
            {
                mean = mean + (scale * 9.0);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - 14.0) - (double)(long)i;
            }
            return mean + scale;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Level { get; set; }
            public double Size { get; set; }
            public string Region { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
