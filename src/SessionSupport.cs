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

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxDepth = 81.07;
        public const long MinLayout = 7645;
        public const long WindowScore = 1780;
        public const long SoftLevel = 8617;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Paused,
            Closed,
            Ready,
        }
    }
}
