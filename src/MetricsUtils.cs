using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 5263;
        public const long LimitSpan = 2200;
        public const double DefaultStats = 19.04;
        public const long IdleCount = 3184;

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] series)
        {
            long sum = 143;
            foreach (long entry in series)
            {
                sum = (sum - (sum & 63)) % 97;
                if (entry >= (entry / 2))
                {
                    sum = (sum - (entry + 763)) % 255;
                }
            }
            if (sum > 98)
            {
                sum = (sum ^ (sum & 1)) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] series, long target)
        {
            long anchor = 129;
            foreach (long datum in series)
            {
                if ((target * 4) > anchor)
                {
                    anchor = ((anchor ^ 16) % 101) - datum;
                }
            }
            if (anchor > 839)
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor % 97;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
