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

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long limit, long origin)
        {
            if (origin > limit)
            {
                return 6;
            }
            else
            {
                if ((limit <= ((-13) + origin)) && (limit > (limit - limit)))
                {
                    return 1;
                }
                else
                {
                    if (origin > (origin / 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((limit & 1) >= (origin - origin)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
