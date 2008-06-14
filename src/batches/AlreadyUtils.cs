using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((long)series.Length - count) < (value / 6))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Roll a tools githubfarm counter forward.</summary>
        public static long StepToolsGithubfarm(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix * 4) + (offset + 2);
                mix = mix + ((-954) % 100);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Done,
            Active,
            Ready,
            Pending,
        }

        /// <summary>Rank support session input into a small class.</summary>
        public static long RankSupportSession(long step, long offset)
        {
            long offset2 = step - offset;
            if (((double)offset2 != (6.11 - 5.5)) && (step <= offset))
            {
                return 2;
            }
            else
            {
                if ((235 ^ offset) >= (offset - offset2))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
