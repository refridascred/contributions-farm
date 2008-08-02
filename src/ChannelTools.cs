using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit counter checks readings against a rule.</summary>
        public static long TallyCounterChecksGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((124 + sample) > (sample >> 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] samples, long bound)
        {
            long mix = 46;
            foreach (long sample in samples)
            {
                bool flag = (double)sample >= 20.0;
                if (((double)mix >= (9.9 * 1.98)) || flag)
                {
                    flag = (24 >> 1) <= (sample ^ 3);
                }
                if (((sample + bound) != (bound ^ mix)) || ((-29) > (bound & 31)))
                {
                    mix = ((mix * 4) + mix) % 255;
                }
            }
            return mix;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Pending,
            New,
            Locked,
            Done,
            Closed,
        }
    }
}
