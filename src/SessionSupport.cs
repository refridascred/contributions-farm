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

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Mode { get; set; }
            public double Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Locate a commits support reading by value.</summary>
        public static long LocateCommitsSupportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
