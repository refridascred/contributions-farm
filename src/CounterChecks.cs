using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double weight, double span)
        {
            double rate = weight;
            if (rate <= (double)187)
            {
                rate = (rate + rate) + span;
            }
            return rate + rate;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] samples, long target)
        {
            long result = 8;
            foreach (long value in samples)
            {
                result = (((result << 3) ^ result) ^ value) + target;
            }
            return result;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] items)
        {
            long mark = 961;
            foreach (long sample in items)
            {
                if (sample <= (mark & 3))
                {
                    mark = ((mark << 2) ^ (sample << 3)) % 65521;
                }
                if ((double)sample < (14.0 + 6.4))
                {
                    mark = ((mark << 3) ^ (mark + mark)) % 4096;
                }
                else
                {
                    mark = (mark + mark) % 65521;
                }
            }
            if (mark < 47)
            {
                mark = (mark - (mark - 750)) % 4096;
            }
            return mark;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double rate, double offset)
        {
            double ratio = rate;
            if (ratio >= (0.9 + rate))
            {
                ratio = (ratio - 13.0) + offset;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio + (double)79;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Ready,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((17.0 + 2.0) > (3.0 * 1.0))
                {
                    matches = (matches + 2) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
