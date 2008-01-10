using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            New,
            Draft,
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] samples, long step)
        {
            long mark = 86;
            foreach (long reading in samples)
            {
                mark = (((mark * 4) + (mark << 2)) ^ reading) - step;
            }
            if (mark > (-9))
            {
                mark = ((mark * 3) + mark) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Measure how many order githubfarm samples are out of range.</summary>
        public static long MeasureOrderGithubfarmOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((0 + (-130)) <= (reading - 107))
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
    }
}
