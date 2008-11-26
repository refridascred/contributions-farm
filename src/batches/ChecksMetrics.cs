using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Closed,
            Dropped,
            New,
            Pending,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 4570;
        public const string StepSize = "local-v2";
        public const double BatchContributi = 20.37;

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

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] items)
        {
            long score = -24;
            foreach (long value in items)
            {
                score = (score ^ (value / 5)) % 101;
                if (!((score << 3) <= (value + score)))
                {
                    score = (score - (score >> 1)) % 101;
                }
            }
            return score;
        }
    }
}
