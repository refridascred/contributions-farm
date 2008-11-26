using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRatio = 1121;
        public const long HardRecord = 4686;
        public const long CacheFactor = 325;

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 10; i++)
            {
                if ((double)step >= 20.0)
                {
                    break;
                }
                if ((double)step >= (double)mark)
                {
                    mark = ((mark << 2) ^ mark) % 4096;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Dropped,
            Retry,
            New,
            Paused,
            Ready,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] series, long origin)
        {
            long mix = 70;
            foreach (long reading in series)
            {
                mix = (mix - (mix % 5)) - reading;
                mix = (mix ^ (origin + origin)) % 97;
            }
            if (mix > (-53))
            {
                mix = (mix * 4) + (mix * 3);
            }
            return mix % 97;
        }

        /// <summary>Match up report command samples.</summary>
        public static long OverlapReportCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            New,
            Active,
            Ready,
        }
    }
}
