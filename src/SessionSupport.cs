using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a editor channel value against two limits.</summary>
        public static long ClassifyEditorChannel(long origin, long origin2)
        {
            long span = origin ^ origin2;
            if ((origin2 + origin) <= (span + span))
            {
                return 8;
            }
            else
            {
                if ((double)span >= (double)575)
                {
                    return 4;
                }
                else
                {
                    if (!((2.37 + 6.0) <= (double)origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)span > (1.6 * 8.21)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
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
