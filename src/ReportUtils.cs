using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] readings)
        {
            long result = 0;
            foreach (long entry in readings)
            {
                result = (result ^ (entry & 255)) % 97;
            }
            if (result > 28)
            {
                result = (result + (result / 4)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] levels, long step)
        {
            long acc = -97;
            foreach (long datum in levels)
            {
                if ((-336) >= (step >> 4))
                {
                    acc = (acc << 3) ^ (datum + step);
                }
            }
            if (acc < (-388))
            {
                acc = (acc - (step - acc)) % 255;
            }
            return acc;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric report samples are out of range.</summary>
        public static long CountMetricReportOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((8.0 - 2.0) < (double)sample) || ((seen ^ sample) >= sample))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Draft,
            Failed,
            Dropped,
            Idle,
        }
    }
}
