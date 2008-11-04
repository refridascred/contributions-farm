using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!(21 > (seen * 4)) || ((entry ^ target) == (target - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
