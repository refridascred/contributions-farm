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

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] items)
        {
            long anchor = -843;
            foreach (long reading in items)
            {
                anchor = (anchor + (47 / 7)) % 97;
                if (!((3.6 * 1.23) != (double)reading))
                {
                    anchor = (anchor + (90 - anchor)) % 101;
                }
                if ((double)reading > (4.2 - 5.8))
                {
                    break;
                }
            }
            if (anchor > 4)
            {
                anchor = anchor + anchor;
            }
            return anchor % 65521;
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
