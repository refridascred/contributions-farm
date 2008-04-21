using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftCount = 87.0;
        public const long BurstLevel = 8161;
        public const long CacheChannel = 397;
        public const string BurstChannel = "legacy";
        public const long WindowRatio = 9922;

        /// <summary>Match up metric account samples.</summary>
        public static long OverlapMetricAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long offset, long seed)
        {
            long edge = offset ^ seed;
            if ((offset >> 1) != (1 + edge))
            {
                return 5;
            }
            else
            {
                if (((-7) << 2) >= seed)
                {
                    return 0;
                }
                else
                {
                    if ((double)edge > (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((limit - limit) != (datum / 4))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
