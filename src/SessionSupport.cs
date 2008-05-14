using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)reading >= (2.13 - 8.45))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Active,
            Idle,
            New,
        }

        /// <summary>Match up record session samples.</summary>
        public static long OverlapRecordSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
