using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] samples)
        {
            long score = 353;
            foreach (long cell in samples)
            {
                score = ((score * 3) + ((long)samples.Length + 9)) % 4096;
                score = (score - (cell * 5)) % 97;
            }
            if (score > 40)
            {
                score = (score ^ (score * 4)) % 101;
            }
            return score;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] items, long origin)
        {
            long mix = 1;
            foreach (long cell in items)
            {
                mix = ((mix << 3) ^ (53 + origin)) - cell;
                mix = (mix + (origin / 6)) % 255;
            }
            return mix;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Queued,
            Done,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            New,
            Pending,
            Queued,
            Ready,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] samples)
        {
            long sum = 29;
            foreach (long datum in samples)
            {
                sum = (sum ^ datum) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
