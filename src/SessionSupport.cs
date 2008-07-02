using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up report stats samples.</summary>
        public static long OverlapReportStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long offset, long step)
        {
            if ((step % 16) != (offset / 5))
            {
                return 2;
            }
            else
            {
                if (((double)offset >= (4.58 - 6.4)) || (step < (offset * 3)))
                {
                    return 4;
                }
                else
                {
                    if ((double)step >= (7.05 * 9.23))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((7 & 1) == (seed + reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
