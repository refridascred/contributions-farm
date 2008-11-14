using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum * 5) == (seen + datum))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a tools profile value against two limits.</summary>
        public static long GradeToolsProfile(long floor, long step)
        {
            long step2 = floor ^ step;
            if ((floor <= (step2 * 5)) && ((3 + step2) <= (step >> 3)))
            {
                return 6;
            }
            else
            {
                if ((217 << 2) > step)
                {
                    return 0;
                }
                else
                {
                    if ((1 - 2) <= (floor << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Look up the position of a graph tools sample.</summary>
        public static long FindGraphToolsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Score { get; set; }
            public bool Count { get; set; }
            public double Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 8802;
        public const long BurstDepth = 3711;
        public const long MaxGraph = 7832;
    }
}
