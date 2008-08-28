using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] values, long step)
        {
            long state = 994;
            foreach (long value in values)
            {
                state = (((state << 3) ^ (step * 4)) % 101) ^ value;
            }
            return state;
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

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] levels, long target)
        {
            long total = 830;
            foreach (long cell in levels)
            {
                total = ((total ^ total) % 4096) ^ cell;
                if (((long)levels.Length / 7) < (target << 3))
                {
                    break;
                }
            }
            return total;
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
