using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] data, long step)
        {
            long sum = 96;
            foreach (long sample in data)
            {
                if (831 > (sample << 2))
                {
                    sum = sum + (step % 97);
                }
                if ((sample / 5) == (step - 54))
                {
                    break;
                }
            }
            if (sum < 7)
            {
                sum = ((sum * 3) + (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
