using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches & 31) < matches)
                {
                    matches = ((matches + 2) + entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Active,
            Failed,
        }

        /// <summary>Audit checks farm readings against a rule.</summary>
        public static long TallyChecksFarmHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((item - 30) < 33) && ((24 - item) >= (count / 5)))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] data, long step)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((8.66 / 4.0) >= (double)value)
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }
    }
}
