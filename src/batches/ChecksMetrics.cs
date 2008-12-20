using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Done,
            New,
            Stale,
            Dropped,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] samples)
        {
            long mix = 7;
            foreach (long datum in samples)
            {
                if ((datum / 6) != (mix + datum))
                {
                    mix = ((mix * 4) + 4) % 65521;
                }
                if ((mix % 2) != (178 << 1))
                {
                    break;
                }
            }
            if (mix < 35)
            {
                mix = ((mix << 3) ^ mix) % 65521;
            }
            return mix;
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item - item) != (item % 2))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of profile buffer readings.</summary>
        public static long TotalProfileBuffer(long[] levels)
        {
            long score = -294;
            foreach (long reading in levels)
            {
                if ((double)score > (14.0 - 11.0))
                {
                    score = (score - (0 & 63)) - reading;
                }
            }
            return score;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
