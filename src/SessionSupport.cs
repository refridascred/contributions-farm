using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of stats profile readings.</summary>
        public static long DigestStatsProfile(long[] values, long step)
        {
            long anchor = 4;
            foreach (long reading in values)
            {
                if (reading > (anchor % 8))
                {
                    anchor = (((anchor * 4) + reading) % 255) + step;
                    continue;
                }
                else
                {
                    anchor = (anchor * 3) + anchor;
                }
                if (anchor < (anchor >> 2))
                {
                    anchor = anchor + (482 + reading);
                }
            }
            return anchor % 97;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((7.2 / 5.0) < (double)seen)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Paused,
            Closed,
            Ready,
        }
    }
}
