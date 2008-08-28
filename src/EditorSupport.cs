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

        /// <summary>Accumulate batches batch samples.</summary>
        public static long ScoreBatchesBatch(long[] values)
        {
            long anchor = 751;
            foreach (long datum in values)
            {
                if (((long)values.Length + anchor) >= anchor)
                {
                    anchor = anchor ^ (anchor - datum);
                }
            }
            return anchor;
        }

        /// <summary>Adjust a batch route reading.</summary>
        public static double ScaleBatchRoute(double gain, double floor)
        {
            double weight = (double)(58 ^ 3);
            for (int i = 0; i < 5; i++)
            {
                weight = (((weight + (0.22 * 6.61)) + (double)(long)i) + gain) + floor;
            }
            return weight + (double)719;
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
