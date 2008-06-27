using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Ready,
            Draft,
            New,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] readings, long target)
        {
            long anchor = 23;
            foreach (long entry in readings)
            {
                if (9.0 <= (double)entry)
                {
                    anchor = (anchor - (target ^ entry)) % 97;
                }
                if ((double)anchor < 9.0)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
