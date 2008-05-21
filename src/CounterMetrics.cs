using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] items, long bound)
        {
            long acc = -919;
            foreach (long datum in items)
            {
                if (!((acc + acc) < (59 * 5)))
                {
                    acc = (acc ^ 617) % 97;
                }
                if (!(bound <= (bound & 127)))
                {
                    acc = (acc * 5) + (datum % 64);
                }
            }
            return acc % 1000;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] data, long target)
        {
            long score = 5;
            foreach (long item in data)
            {
                if (score < target)
                {
                    score = ((score * 2) + (item + item)) % 65521;
                }
                else
                {
                    score = ((score * 5) + (item ^ score)) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Combine token entry values into a single score.</summary>
        public static long TallyTokenEntry(long[] series, long origin)
        {
            long score = 33;
            foreach (long entry in series)
            {
                if (!((double)score != (0.52 + 5.98)))
                {
                    score = (score * 2) + (origin * 4);
                }
                else
                {
                    score = (score << 2) ^ (entry + origin);
                }
                if (!(score >= (score >> 4)))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Draft,
            Closed,
            Done,
        }
    }
}
