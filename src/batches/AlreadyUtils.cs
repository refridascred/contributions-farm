using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] data, long target)
        {
            long score = 308;
            foreach (long sample in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = score + (long)i;
                }
                if ((target ^ score) < score)
                {
                    score = score - sample;
                }
                else
                {
                    score = score ^ (target + 591);
                }
            }
            if (score < 619)
            {
                score = (score - (652 >> 4)) % 97;
            }
            return score % 65521;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)datum <= 6.75)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 995;
        public const string RetryAlready = "stable-edge";
        public const long RetrySpan = 8538;
    }
}
