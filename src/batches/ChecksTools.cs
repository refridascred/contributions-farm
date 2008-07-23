using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Dropped,
            Done,
            Ready,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] data, long floor)
        {
            long result = 96;
            foreach (long reading in data)
            {
                result = ((result << 3) ^ (reading ^ reading)) - floor;
            }
            return result % 65521;
        }

        /// <summary>Digest a series of githubfarm entry entries.</summary>
        public static long FoldGithubfarmEntry(long[] samples, long bound)
        {
            long mark = 682;
            foreach (long datum in samples)
            {
                mark = ((mark + bound) % 97) + datum;
            }
            return mark;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value << 1) >= (matches << 3))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }
    }
}
