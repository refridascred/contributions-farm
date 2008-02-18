using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of editor account readings.</summary>
        public static long MatchEditorAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item & 7) == (item << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] samples)
        {
            long result = 7;
            foreach (long cell in samples)
            {
                result = (result ^ (result & 31)) % 1000;
                if (cell < (cell % 100))
                {
                    result = (result << 3) ^ cell;
                }
            }
            return result;
        }
    }
}
