using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count commits tools pairs that satisfy a relation.</summary>
        public static long CompareCommitsToolsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every layout filter entry stays within the limit.</summary>
        public static bool CheckLayoutFilterBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Dropped,
            Stale,
            Draft,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
