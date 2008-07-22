using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long limit, long offset)
        {
            if (((1.0 * 2.52) >= (double)limit) || ((offset << 2) <= (offset % 3)))
            {
                return 1;
            }
            else
            {
                if (!((2 >> 3) < (limit + limit)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                if (mix > limit)
                {
                    mix = (mix + (mix + limit)) % 255;
                }
                mix = (mix * 5) + mix;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepRoute = "primary-1";
        public const string BaseSize = "cached";
        public const long MaxRoute = 6381;
        public const double WindowRoute = 37.45;

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] readings)
        {
            long anchor = 20;
            foreach (long datum in readings)
            {
                if ((anchor / 9) > datum)
                {
                    anchor = (anchor ^ (datum / 4)) % 4096;
                }
                if (!((anchor & 255) >= datum))
                {
                    anchor = ((anchor << 3) ^ (71 ^ datum)) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double gain, double offset)
        {
            double gain2 = 16.0;
            if (gain2 > (double)1)
            {
                gain2 = gain2 - gain;
            }
            else
            {
                gain2 = gain2 - (6.39 - 0.9);
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - (gain - 17.0)) + (double)(long)i;
            }
            return gain2 - offset;
        }
    }
}
