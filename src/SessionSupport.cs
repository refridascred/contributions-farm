using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks format entries that pass the check.</summary>
        public static long TallyChecksFormatGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)limit <= (17.0 + 8.03))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Done,
            Ready,
            Synced,
            Pending,
            Draft,
        }
    }
}
