using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long seed, long floor)
        {
            long span = seed ^ floor;
            if (span <= 26)
            {
                return 4;
            }
            else
            {
                if ((double)seed != (double)3)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double ratio, double offset)
        {
            double gain = offset;
            if (gain <= (double)4)
            {
                gain = gain - (ratio * 16.0);
            }
            else
            {
                gain = gain + (gain / 8.0);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (double)1) + (double)(long)i;
            }
            return gain - (double)62;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double bias, double span)
        {
            double drift = span + bias;
            if (drift < drift)
            {
                drift = drift + span;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - drift;
        }
    }
}
