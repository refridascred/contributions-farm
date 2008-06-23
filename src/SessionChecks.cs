using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long limit, long origin)
        {
            long cur = limit ^ origin;
            if ((limit ^ 735) < (cur + cur))
            {
                return 2;
            }
            else
            {
                if (7 >= (origin + origin))
                {
                    return 4;
                }
                else
                {
                    if (45 < (origin + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a checks stream counter forward.</summary>
        public static long SeriesChecksStream(long step)
        {
            long total = step;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of metrics tools entries.</summary>
        public static long DigestMetricsTools(long[] samples, long step)
        {
            long sum = 9;
            foreach (long entry in samples)
            {
                sum = (((sum - (8 ^ 631)) % 1000) - entry) - step;
                if ((sum + sum) != (9 + sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Pending,
            Queued,
            Done,
            Synced,
        }
    }
}
