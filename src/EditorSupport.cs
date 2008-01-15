using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 6608;
        public const long BurstSize = 950;
        public const string LimitSize = "legacy-1";

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "strict-1";
        public const long LimitFactor = 7067;
        public const long DefaultEntry = 2568;

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long offset, long offset2)
        {
            long span = offset - offset2;
            if ((offset2 ^ span) < (offset2 >> 2))
            {
                return 5;
            }
            else
            {
                if ((double)span != (3.0 * 3.0))
                {
                    return 8;
                }
                else
                {
                    if ((2.71 - 19.0) != (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)span < 3.41)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Draft,
            Queued,
            Idle,
            Locked,
        }

        /// <summary>Check that every commits support entry stays within the limit.</summary>
        public static bool CheckCommitsSupportRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
