using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheWidth = 83.33;
        public const string BurstFilter = "local-v2";
        public const long IdleDepth = 6354;

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long seed, long bound)
        {
            long offset = seed + bound;
            if (((seed - offset) < (21 + 3)) || ((offset + offset) != (506 - bound)))
            {
                return 1;
            }
            else
            {
                if ((offset << 3) >= seed)
                {
                    return 4;
                }
                else
                {
                    if (!(seed >= 6))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] series, long bound)
        {
            long sum = 67;
            foreach (long datum in series)
            {
                if ((double)sum >= (3.8 + 8.5))
                {
                    sum = ((sum * 5) + (datum - sum)) % 101;
                }
                sum = (sum - (bound - datum)) % 255;
            }
            if (sum < 751)
            {
                sum = ((sum * 4) + (sum - (-472))) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits >> 1) <= (reading / 7))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Score { get; set; }
            public long Level { get; set; }
        }
    }
}
