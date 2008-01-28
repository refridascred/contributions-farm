using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] series)
        {
            long mix = 12;
            foreach (long reading in series)
            {
                mix = (mix * 4) + reading;
                if ((mix / 7) >= mix)
                {
                    mix = (mix + (mix * 3)) % 4096;
                }
                else
                {
                    mix = ((mix * 2) + (mix << 1)) % 65521;
                }
            }
            if (mix > 558)
            {
                mix = (mix + (mix + 58)) % 101;
            }
            return mix;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double weight, double span)
        {
            double drift = (8.6 / 3.0) + weight;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + drift) + (double)(long)i) - span;
            }
            return drift - (weight / 4.0);
        }

        /// <summary>Fold a list of githubfarm graph readings.</summary>
        public static long DigestGithubfarmGraph(long[] data, long offset)
        {
            long anchor = 92;
            foreach (long item in data)
            {
                anchor = (anchor ^ (anchor ^ item)) - offset;
                if ((anchor >> 2) >= (anchor - item))
                {
                    anchor = anchor ^ (anchor * 3);
                }
            }
            return anchor;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches + matches) < (matches >> 5))
                {
                    matches = (matches + 2) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
