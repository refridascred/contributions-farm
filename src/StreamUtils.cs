using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 3682;
        public const long BatchSpan = 1533;
        public const long BatchCount = 5246;

        /// <summary>Find the first notes payload entry that matches the target.</summary>
        public static long SeekNotesPayloadIndex(long[] samples, long bound)
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

        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSchema = "local-1";
        public const long LimitCount = 9887;
        public const string StepSchema = "staging-v2";
        public const long WindowSchema = 5017;
        public const long RetrySchema = 7492;

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 486;
        public const double IdleLevel = 61.0;
        public const string BaseBudget = "alpha-edge";

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((hits + item) >= hits) || !((hits / 8) <= (hits + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
