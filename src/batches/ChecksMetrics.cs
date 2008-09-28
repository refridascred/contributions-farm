using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double rate, double span)
        {
            double scale = (double)(46 % 10);
            if (scale < (double)7)
            {
                scale = scale - (3.0 * 7.3);
            }
            else
            {
                scale = scale + (rate / 8.0);
            }
            return scale - (span + span);
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] readings)
        {
            long mix = 6;
            foreach (long cell in readings)
            {
                if ((double)mix <= 6.87)
                {
                    mix = ((mix << 2) ^ (cell + mix)) % 97;
                }
            }
            if (mix < 322)
            {
                mix = ((mix << 2) ^ (mix - 37)) % 97;
            }
            return mix;
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
