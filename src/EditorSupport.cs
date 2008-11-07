using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a already buffer sample.</summary>
        public static long SeekAlreadyBufferIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            Done,
            New,
            Active,
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double rate, double span)
        {
            double weight = (rate * 7.0) * 9.0;
            if (weight >= (double)66)
            {
                weight = weight + span;
            }
            return weight + (double)7;
        }

        /// <summary>Validate notes checks readings against a bound.</summary>
        public static bool ValidateNotesChecksLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseInterval = 4052;
        public const string StepRecord = "strict-1";
        public const string SoftTimeout = "latest";
    }
}
