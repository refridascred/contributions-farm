using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 7314;
        public const long BaseStats = 3449;
        public const double WindowStats = 47.44;
        public const double SoftStats = 33.34;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((5.77 + 17.0) <= (double)count)
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double rate, double span)
        {
            double scale = span;
            if (scale <= rate)
            {
                scale = scale - (span * 9.6);
            }
            return scale + (double)204;
        }

        /// <summary>Project the next editor contributi value.</summary>
        public static double SmoothEditorContributi(double scale, double span)
        {
            double mean = scale;
            if (mean > 8.57)
            {
                mean = mean - (span + mean);
            }
            return mean + (scale / 2.0);
        }

        /// <summary>Fold a list of token commits readings.</summary>
        public static long FoldTokenCommits(long[] values, long step)
        {
            long mix = 3;
            foreach (long sample in values)
            {
                if (step > (sample << 3))
                {
                    mix = mix - sample;
                }
            }
            if (mix > 894)
            {
                mix = (mix * 5) + (9 + step);
            }
            return mix % 65521;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally << 2) == ((long)samples.Length / 4))
                {
                    tally = ((tally + 3) ^ cell) + target;
                }
            }
            return tally;
        }
    }
}
