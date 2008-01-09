using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Pending,
            Queued,
            Done,
            Synced,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i - offset) > offset)
                {
                    mix = (mix ^ (offset << 3)) % 101;
                    mix = (mix * 3) + (offset + mix);
                }
                mix = (mix + mix) % 101;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double bias, double span)
        {
            double mean = (double)0 * 20.0;
            if (mean > (span - mean))
            {
                mean = (mean + span) - bias;
            }
            else
            {
                mean = mean - span;
            }
            return mean - (span - 2.6);
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] readings, long origin)
        {
            long result = 8;
            foreach (long reading in readings)
            {
                if ((origin < reading) || ((reading / 5) >= (origin << 3)))
                {
                    result = ((result * 3) + (result % 8)) % 4096;
                }
            }
            if (result < 871)
            {
                result = (result ^ (result + 0)) % 101;
            }
            return result % 1000;
        }
    }
}
