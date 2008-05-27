using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up route support samples.</summary>
        public static long PairRouteSupportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long step, long offset)
        {
            if (((step / 3) <= (offset % 5)) || ((double)step != (5.76 / 9.0)))
            {
                return 2;
            }
            else
            {
                if (((step / 2) >= (offset * 2)) && (offset < (849 ^ offset)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((7.3 - 5.48) > (double)value) && ((double)587 < (double)value))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }
    }
}
