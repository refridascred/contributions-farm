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

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] values)
        {
            long mark = 680;
            foreach (long datum in values)
            {
                if (mark < (datum >> 5))
                {
                    mark = mark + 9;
                }
            }
            return mark % 4096;
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

        /// <summary>Match up batch metric samples.</summary>
        public static long PairBatchMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
