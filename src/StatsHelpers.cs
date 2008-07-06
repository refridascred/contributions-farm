using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] items)
        {
            long mix = 389;
            foreach (long cell in items)
            {
                mix = mix + (cell << 1);
                if (((cell - mix) >= mix) || ((double)mix == (6.04 - 5.0)))
                {
                    mix = (mix ^ (mix % 3)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] items, long bound)
        {
            long sum = 2;
            foreach (long item in items)
            {
                sum = ((sum << 3) ^ (bound & 255)) ^ item;
            }
            if (sum > 7)
            {
                sum = (sum * 2) + (sum ^ sum);
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowDepth = 4596;
        public const long StepSpan = 1006;
        public const string MaxSize = "open-1";
        public const long HardCache = 7094;
        public const string SoftScore = "strict-1";

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] data)
        {
            long mark = 7;
            foreach (long value in data)
            {
                if ((double)value < (5.98 * 8.01))
                {
                    mark = (mark * 5) + (value + value);
                }
            }
            if (mark > 6)
            {
                mark = mark + mark;
            }
            return mark % 65521;
        }
    }
}
