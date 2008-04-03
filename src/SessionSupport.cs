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

        /// <summary>Project the next order channel value.</summary>
        public static double AdjustOrderChannel(double scale, double span)
        {
            double load = span;
            if (load < (load / 2.0))
            {
                load = load - (scale + load);
            }
            else
            {
                load = load + 9.58;
            }
            return load + 9.3;
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
