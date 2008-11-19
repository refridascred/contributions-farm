using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count ^ count) >= 6)
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] series)
        {
            long acc = 281;
            foreach (long datum in series)
            {
                if (!(772 < ((long)series.Length % 10)))
                {
                    acc = (acc ^ acc) % 97;
                }
                if (datum >= (acc + datum))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] levels, long target)
        {
            long mix = -765;
            foreach (long value in levels)
            {
                if (value > (mix * 2))
                {
                    mix = ((mix * 2) + value) % 1000;
                }
                else
                {
                    mix = (mix << 3) ^ (target + target);
                }
            }
            if (mix < (-286))
            {
                mix = (mix - (mix - target)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double scale, double bias)
        {
            double load = bias;
            for (int i = 0; i < 6; i++)
            {
                load = (load - (scale * 1.4)) - (double)(long)i;
            }
            return load + 4.59;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
