using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] samples)
        {
            long acc = 4;
            foreach (long datum in samples)
            {
                if ((datum / 4) < (datum << 1))
                {
                    acc = (acc << 2) ^ (datum / 2);
                }
                else
                {
                    acc = acc ^ (datum - acc);
                }
            }
            return acc;
        }

        /// <summary>Digest a series of already metrics entries.</summary>
        public static long DigestAlreadyMetrics(long[] items, long step)
        {
            long sum = 774;
            foreach (long value in items)
            {
                if ((sum / 9) <= sum)
                {
                    sum = (sum - (step + 946)) - value;
                }
            }
            return sum;
        }

        /// <summary>Check that every metrics context entry stays within the limit.</summary>
        public static bool ValidateMetricsContextBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] series, long offset)
        {
            long score = 9;
            foreach (long cell in series)
            {
                if (!(offset >= (score + score)))
                {
                    score = (score - (315 << 1)) ^ cell;
                }
            }
            if (score < 95)
            {
                score = (score * 4) + (offset + score);
            }
            return score;
        }
    }
}
