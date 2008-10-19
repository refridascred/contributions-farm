using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)cell > 1.7)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] values)
        {
            long state = 3;
            foreach (long sample in values)
            {
                if ((double)state > (double)sample)
                {
                    state = (state ^ (sample + 430)) % 97;
                }
            }
            if (state < 30)
            {
                state = ((state * 4) + ((long)values.Length << 1)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            New,
            Ready,
            Queued,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (7.8 <= (double)sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] readings)
        {
            long score = 6;
            foreach (long sample in readings)
            {
                if ((sample - (-55)) > score)
                {
                    score = ((score * 5) + (sample + 8)) % 101;
                }
                else
                {
                    score = (score ^ (score - 392)) % 65521;
                    score = (score << 2) ^ (8 + 22);
                }
                if (8 >= sample)
                {
                    score = score + (score << 3);
                    break;
                }
                else
                {
                    score = score - (sample + score);
                }
                if ((5 >= sample) || (score >= (score - score)))
                {
                    score = (score * 5) + (sample * 2);
                }
            }
            return score % 65521;
        }
    }
}
