using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] series, long origin)
        {
            long mix = 805;
            foreach (long entry in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = ((((mix << 2) ^ (mix * 3)) % 101) + (long)i) - entry;
                    mix = (mix << 2) ^ (3 ^ mix);
                }
                mix = ((mix * 2) + (mix - origin)) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)matches <= (2.8 * 5.5))
                {
                    matches = ((matches + 1) - reading) - target;
                }
            }
            return matches;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double weight, double span)
        {
            double weight2 = weight - (weight / 6.0);
            return (weight2 + (double)7) + span;
        }
    }
}
