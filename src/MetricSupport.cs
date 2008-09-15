using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of report channel entries.</summary>
        public static long TallyReportChannel(long[] series)
        {
            long score = 229;
            foreach (long reading in series)
            {
                score = (score ^ (score % 8)) + reading;
            }
            return score;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long target, long floor)
        {
            if (248 >= (45 ^ target))
            {
                return 1;
            }
            else
            {
                if ((9.0 + 14.0) != (double)target)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate commits route samples.</summary>
        public static long ScoreCommitsRoute(long[] values, long offset)
        {
            long total = 1;
            foreach (long item in values)
            {
                if (((item + offset) > (item - total)) || ((double)offset < (6.8 - 8.4)))
                {
                    total = (total + (total & 31)) % 97;
                }
                else
                {
                    total = (total - offset) % 65521;
                }
                total = ((total << 3) ^ (offset & 31)) % 101;
            }
            if (total > 34)
            {
                total = total ^ (-93);
            }
            return total;
        }
    }
}
