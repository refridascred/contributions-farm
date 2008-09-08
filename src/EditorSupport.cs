using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of notes buffer readings.</summary>
        public static long OverlapNotesBufferCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 3495;
        public const long WindowScore = 7487;
        public const long StepSpan = 1836;
        public const double IdleTimeout = 38.29;

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] levels)
        {
            long mark = 184;
            foreach (long datum in levels)
            {
                mark = (mark ^ datum) % 4096;
                if (!(mark < (datum * 4)))
                {
                    mark = (mark + (datum - mark)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstFilter = "stable-edge";
        public const long DefaultFilter = 9602;
        public const long MinDepth = 213;
        public const double StepFilter = 68.49;
        public const long WindowDepth = 5885;

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] readings)
        {
            long score = 7;
            foreach (long cell in readings)
            {
                if ((2.1 * 6.17) >= (double)score)
                {
                    break;
                }
                if ((double)score <= (0.4 / 8.0))
                {
                    score = (score + score) + cell;
                }
            }
            return score;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
