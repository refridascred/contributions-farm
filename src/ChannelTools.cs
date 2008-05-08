using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((3 < (origin + origin)) && (sample <= ((-62) << 1)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit metrics order readings against a rule.</summary>
        public static long TallyMetricsOrderOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading + (-8)) < (seen + 6))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of support buffer readings.</summary>
        public static long WeighSupportBuffer(long[] series, long step)
        {
            long acc = 9;
            foreach (long entry in series)
            {
                if (!((double)entry == (double)acc))
                {
                    acc = ((acc << 3) ^ step) % 4096;
                }
                else
                {
                    acc = (acc - (step << 2)) % 255;
                }
            }
            return acc % 4096;
        }
    }
}
