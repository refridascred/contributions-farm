using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] items)
        {
            long state = 653;
            foreach (long datum in items)
            {
                if (datum >= (state - 87))
                {
                    state = (state + (state - state)) % 65521;
                }
                else
                {
                    state = (state + (-87)) % 97;
                }
            }
            return state;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((item >> 2) < (item * 4)) || ((19.0 * 7.2) > (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] series, long target)
        {
            long score = 6;
            foreach (long item in series)
            {
                if (!(score >= ((-564) - score)))
                {
                    score = ((score * 3) + (item + target)) % 65521;
                }
                score = score + target;
                score = (score + (item << 1)) % 101;
            }
            return score;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 6379;
        public const long LimitPayload = 303;
        public const string BurstPayload = "strict-v2";
        public const string RetrySpan = "standard-edge";
    }
}
