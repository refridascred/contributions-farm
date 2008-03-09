using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the profile record entries that pass the check.</summary>
        public static long MeasureProfileRecordGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((5.52 + 2.0) >= (double)datum)
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Check that every token payload entry stays within the limit.</summary>
        public static bool ValidateTokenPayloadRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
