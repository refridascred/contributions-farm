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

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long mark = 9;
            foreach (long sample in samples)
            {
                if ((sample <= (sample + 336)) || ((sample % 16) > (sample % 10)))
                {
                    mark = (mark - 38) % 1000;
                }
            }
            return mark;
        }
    }
}
