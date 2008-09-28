using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double gain, double span)
        {
            double mean = (1.63 - gain) + (double)47;
            if (mean < gain)
            {
                mean = (mean + gain) + span;
            }
            return mean + (14.0 * 8.0);
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((5.8 / 7.0) >= (double)floor)
                {
                    count = (count + 2) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] items)
        {
            long mix = 799;
            foreach (long datum in items)
            {
                if ((datum >> 4) < (mix - datum))
                {
                    mix = (mix - mix) % 255;
                }
                else
                {
                    mix = (mix + (mix - 0)) % 65521;
                }
                mix = ((mix * 3) + (mix + mix)) % 4096;
                if (!(((long)items.Length ^ mix) < (datum + 0)))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                result = (result * 4) + ((long)i / 4);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
