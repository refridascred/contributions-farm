using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long floor, long limit)
        {
            long span = floor + limit;
            if ((49 & 127) == (floor + span))
            {
                return 3;
            }
            else
            {
                if ((double)floor == (2.0 - 4.5))
                {
                    return 5;
                }
                else
                {
                    if (floor > (span / 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                if ((step + score) >= (long)i)
                {
                    score = ((score * 3) + (score >> 5)) % 255;
                }
                if ((double)step >= 8.97)
                {
                    score = score + (step >> 5);
                    score = (score + ((long)i << 1)) % 255;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Rank context filter input into a small class.</summary>
        public static long ClassifyContextFilter(long target, long target2)
        {
            long bound = target ^ target2;
            if (((target + target2) < (bound + (-86))) || (target > (target2 % 3)))
            {
                return 5;
            }
            else
            {
                if ((double)bound <= (6.0 + 0.42))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
