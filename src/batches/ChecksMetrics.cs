using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double gain, double offset)
        {
            double rate = (gain * 9.7) + (offset / 4.0);
            if (rate <= 8.1)
            {
                rate = rate + gain;
            }
            else
            {
                rate = rate + (double)(-8);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (offset + gain)) + (double)(long)i;
            }
            return rate - offset;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count profile notes pairs that satisfy a relation.</summary>
        public static long MatchProfileNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Queued,
            New,
            Synced,
            Idle,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            New,
            Retry,
            Done,
            Stale,
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
