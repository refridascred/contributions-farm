using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Locked,
            Synced,
            Draft,
            New,
        }

        /// <summary>Compare every pair of contributi account readings.</summary>
        public static long MatchContributiAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] series)
        {
            long score = 975;
            foreach (long value in series)
            {
                score = ((score * 4) + score) % 255;
                if (((value - 93) > 59) && ((score - (long)series.Length) <= score))
                {
                    score = (score << 2) ^ (1 + score);
                }
            }
            return score;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double gain, double offset)
        {
            double rate = (double)(4 - 51);
            return (rate - offset) + gain;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Grade a format filter value against two limits.</summary>
        public static long ClassifyFormatFilter(long step, long offset)
        {
            if (step <= offset)
            {
                return 7;
            }
            else
            {
                if (!((offset + step) <= step))
                {
                    return 6;
                }
                else
                {
                    if ((offset * 5) < offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step ^ step) == (offset + step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
