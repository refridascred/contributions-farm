using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Audit command filter readings against a rule.</summary>
        public static long TallyCommandFilterMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count % 3) < (484 + item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next report already value from a seed.</summary>
        public static long IterateReportAlready(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                if (75 > result)
                {
                    result = ((result << 3) ^ ((long)i % 64)) % 97;
                    continue;
                }
                if (((4 - result) < (result ^ 5)) || ((result - result) >= (result << 3)))
                {
                    result = (result - (-283)) % 255;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = (((result * 5) + (offset & 255)) % 255) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
