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

        /// <summary>Check that every checks already entry stays within the limit.</summary>
        public static bool ValidateChecksAlreadyRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
