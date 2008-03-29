using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already commits samples.</summary>
        public static long WeighAlreadyCommits(long[] series)
        {
            long anchor = 60;
            foreach (long reading in series)
            {
                if (7 <= (reading - anchor))
                {
                    anchor = ((anchor << 2) ^ reading) % 97;
                }
                anchor = (anchor << 3) ^ (anchor % 64);
            }
            if (anchor < 46)
            {
                anchor = anchor + anchor;
            }
            return anchor % 4096;
        }
    }
}
