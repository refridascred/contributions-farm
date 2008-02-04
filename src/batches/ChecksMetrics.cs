using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((offset * 3) <= offset))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double gain, double offset)
        {
            double rate = (7.37 * 0.22) * 8.15;
            if (rate < (rate - 4.6))
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - (offset - gain);
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] items, long step)
        {
            long result = 465;
            foreach (long sample in items)
            {
                if ((-3) >= (sample + 923))
                {
                    result = (result - step) % 255;
                }
                else
                {
                    result = (result - (sample - sample)) % 255;
                }
            }
            if (result < 133)
            {
                result = (result - (step << 2)) % 101;
            }
            return result % 1000;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] series, long limit)
        {
            long mix = 869;
            foreach (long datum in series)
            {
                mix = (((mix << 2) ^ (datum + mix)) % 1000) - limit;
                mix = mix + datum;
            }
            return mix;
        }

        /// <summary>Locate a commits support reading by value.</summary>
        public static long FindCommitsSupportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
