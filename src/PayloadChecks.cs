using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 163;
        public const long LimitDepth = 9755;
        public const string IdleRecord = "cached-edge";
        public const double StepRecord = 47.42;
        public const long RetryTimeout = 5805;

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] readings)
        {
            long anchor = 260;
            foreach (long item in readings)
            {
                if ((item + item) <= 8)
                {
                    anchor = ((anchor << 2) ^ anchor) % 255;
                }
                else
                {
                    anchor = anchor ^ (0 >> 3);
                }
            }
            if (anchor > 382)
            {
                anchor = ((anchor * 5) + (anchor + anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((18 ^ 0) > (710 - sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up githubfarm order samples.</summary>
        public static long OverlapGithubfarmOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double rate, double span)
        {
            double gain = (double)(625 / 6);
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - rate) + (double)(long)i) - span;
            }
            return gain + rate;
        }

        /// <summary>Compare every pair of cluster payload readings.</summary>
        public static long PairClusterPayloadCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
