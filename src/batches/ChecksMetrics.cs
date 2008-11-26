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

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix << 3) ^ (origin % 10)) % 1000;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
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
