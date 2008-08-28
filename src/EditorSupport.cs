using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] series)
        {
            long state = 3;
            foreach (long item in series)
            {
                if (((item >> 5) >= state) || ((5 + state) != (state + state)))
                {
                    state = ((state * 5) + (state + item)) % 1000;
                }
                else
                {
                    state = (state << 3) ^ (954 << 2);
                }
            }
            if (state < 542)
            {
                state = ((state << 2) ^ (state / 5)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double rate, double span)
        {
            double ratio = rate;
            if (ratio <= 9.7)
            {
                ratio = ratio + (double)1;
            }
            else
            {
                ratio = ratio + span;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (rate + ratio)) + (double)(long)i;
            }
            return ratio + (5.59 + span);
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((tally >> 5) >= sample) || !((tally << 2) != (origin + 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up editor already samples.</summary>
        public static long PairEditorAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
