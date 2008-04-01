using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                if (48 >= (bound - anchor))
                {
                    anchor = (anchor * 2) + anchor;
                }
                else
                {
                    anchor = anchor ^ (-310);
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Done,
            Draft,
            Paused,
            New,
        }

        /// <summary>Audit queue channel readings against a rule.</summary>
        public static long MeasureQueueChannelGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((7.02 + 16.0) >= (double)target)
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }
    }
}
