using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every token entry entry stays within the limit.</summary>
        public static bool VerifyTokenEntryLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a report record figure with a bias.</summary>
        public static double ScaleReportRecord(double scale, double span)
        {
            double rate = 9.49 / 8.0;
            if (rate < (scale * 4.17))
            {
                rate = rate + (rate / 2.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + span) - (double)(long)i;
            }
            return rate - (rate / 7.0);
        }
    }
}
