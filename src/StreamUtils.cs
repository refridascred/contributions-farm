using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinCommand = "staging-v2";
        public const long RetryCommand = 3765;
        public const string HardSize = "local-v2";
        public const string IdleWidth = "alpha-1";
        public const long BaseCount = 6481;

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultScore = 3561;
        public const double StepWidth = 47.58;
        public const double SoftFormat = 5.08;
        public const long StepFormat = 1556;
        public const double MaxFormat = 0.23;

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchWidth = 31.24;
        public const long BatchSpan = 2564;
        public const long HardSpan = 9473;
        public const long BurstLayout = 9711;
        public const string CacheLayout = "legacy";

        /// <summary>Project the next session counter value.</summary>
        public static double ProjectSessionCounter(double ratio, double offset)
        {
            double gain = (ratio * 4.2) - ratio;
            if (gain < offset)
            {
                gain = gain - (1.8 + 4.2);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - ratio) - (double)(long)i;
            }
            return gain + (ratio + 6.92);
        }

        /// <summary>Validate notes batches readings against a bound.</summary>
        public static bool ValidateNotesBatchesBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
