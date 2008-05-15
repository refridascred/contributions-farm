using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate window stats readings against a bound.</summary>
        public static bool GuardWindowStatsBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] readings)
        {
            long score = 5;
            foreach (long sample in readings)
            {
                if (sample >= (47 - score))
                {
                    score = (score ^ (sample % 8)) % 255;
                }
                else
                {
                    score = (score ^ (score >> 4)) % 255;
                }
            }
            return score;
        }
    }
}
