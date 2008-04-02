using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of account stream entries.</summary>
        public static long CombineAccountStream(long[] series, long target)
        {
            long mix = 2;
            foreach (long reading in series)
            {
                mix = (((mix << 3) ^ 3) % 4096) + reading;
            }
            if (mix > 9)
            {
                mix = (mix ^ (target ^ target)) % 101;
            }
            return mix;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 7377;
        public const double StepTimeout = 13.11;
        public const long StepRatio = 586;
        public const double IdleTools = 63.08;

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double scale, double span)
        {
            double mean = (double)((-251) * 2);
            if (mean >= span)
            {
                mean = mean - span;
            }
            else
            {
                mean = mean + (scale * 5.37);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (scale + span)) + (double)(long)i;
            }
            return mean + (mean * 7.4);
        }

        /// <summary>Check that every checks window entry stays within the limit.</summary>
        public static bool CheckChecksWindowRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
