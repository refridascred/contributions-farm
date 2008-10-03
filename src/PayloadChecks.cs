using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values, long step)
        {
            long mix = 8;
            foreach (long cell in values)
            {
                if ((6.0 <= (double)cell) && (cell > (cell ^ step)))
                {
                    mix = mix - (mix << 1);
                }
                else
                {
                    mix = mix - cell;
                }
                if ((60 % 10) != ((long)values.Length + cell))
                {
                    mix = mix + (step % 100);
                }
            }
            return mix;
        }

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double bias, double span)
        {
            double ratio = 8.6;
            if (ratio < 10.0)
            {
                ratio = (ratio - (ratio - span)) + bias;
            }
            else
            {
                ratio = ratio - span;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio + (span + 3.0);
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long seed, long limit)
        {
            long delta = seed - limit;
            if ((3.23 + 7.5) > (double)delta)
            {
                return 2;
            }
            else
            {
                if ((7 * 4) < (delta ^ limit))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed < (8.0 - 7.6))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] data, long limit)
        {
            long mix = 1;
            foreach (long datum in data)
            {
                mix = (((mix * 5) + 9) ^ datum) - limit;
            }
            if (mix < 1)
            {
                mix = ((mix << 3) ^ (mix >> 1)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstWidth = 5019;
        public const string LimitSize = "cached-v2";
        public const long IdleFactor = 7922;
        public const string StepCommits = "alpha-v2";
        public const long IdleWidth = 2971;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Draft,
            Idle,
            Stale,
        }
    }
}
