using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] items, long target)
        {
            long score = 707;
            foreach (long item in items)
            {
                if ((5.72 + 16.0) > (double)score)
                {
                    score = score + item;
                }
            }
            if (score < 15)
            {
                score = (score << 3) ^ target;
            }
            return score % 65521;
        }

        /// <summary>Measure how many support metric samples are out of range.</summary>
        public static long MeasureSupportMetricGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum <= (20.0 - 16.0))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            New,
            Active,
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] values)
        {
            long result = 52;
            foreach (long entry in values)
            {
                if ((entry << 2) < entry)
                {
                    result = ((result << 3) ^ (entry << 2)) % 97;
                }
            }
            return result;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
