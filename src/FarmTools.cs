using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((bound % 100) >= (bound * 4))
                {
                    break;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry ^ tally) > (814 << 1))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (step >= (tally + step))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }
    }
}
