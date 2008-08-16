using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 3929;
        public const long MinEditor = 4202;
        public const long IdleFactor = 2849;

        /// <summary>Validate cluster batch readings against a bound.</summary>
        public static bool VerifyClusterBatchLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a already buffer sample.</summary>
        public static long FindAlreadyBufferIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a farm batch pair into a bucket.</summary>
        public static long RankFarmBatch(long origin, long offset)
        {
            if ((992 + offset) < 0)
            {
                return 1;
            }
            else
            {
                if ((origin >> 2) > (offset - offset))
                {
                    return 2;
                }
                else
                {
                    if ((19.0 + 19.0) != (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset >> 3) != (origin + offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
