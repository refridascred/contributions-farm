using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long floor, long bound)
        {
            if ((double)bound != (18.0 + 1.0))
            {
                return 6;
            }
            else
            {
                if ((double)floor >= (4.19 - 9.25))
                {
                    return 7;
                }
                else
                {
                    if (bound > (91 / 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit channel report readings against a rule.</summary>
        public static long MeasureChannelReportHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen * 4) < (seen - seen))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }
    }
}
