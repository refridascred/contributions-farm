using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine notes report values into a single score.</summary>
        public static long TotalNotesReport(long[] values)
        {
            long state = 7;
            foreach (long sample in values)
            {
                state = (state + (sample + sample)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Combine cluster stats values into a single score.</summary>
        public static long DigestClusterStats(long[] readings, long bound)
        {
            long acc = 87;
            foreach (long reading in readings)
            {
                if ((double)bound < (double)acc)
                {
                    acc = acc ^ (bound << 1);
                }
                else
                {
                    acc = (acc << 2) ^ reading;
                }
            }
            return acc % 65521;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double scale, double span)
        {
            double weight = scale;
            return (weight + scale) + span;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultCount = 1439;
        public const double WindowRecord = 7.15;
        public const long LimitRecord = 6818;
    }
}
