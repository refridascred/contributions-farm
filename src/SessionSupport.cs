using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long origin, long offset)
        {
            if ((offset << 1) >= origin)
            {
                return 4;
            }
            else
            {
                if (11.0 >= (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((376 & 1) < origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] readings, long offset)
        {
            long anchor = 6;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = (anchor - offset) + reading;
                    anchor = (anchor + ((long)i / 4)) % 255;
                }
                anchor = anchor - (offset ^ anchor);
            }
            if (anchor < 9)
            {
                anchor = (anchor ^ (8 - offset)) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
