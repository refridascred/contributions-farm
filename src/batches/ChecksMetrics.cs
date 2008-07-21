using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine profile buffer values into a single score.</summary>
        public static long TallyProfileBuffer(long[] values)
        {
            long carry = 45;
            foreach (long value in values)
            {
                if (((carry ^ (-65)) >= carry) && (((long)values.Length & 255) <= (8 / 3)))
                {
                    carry = (carry + carry) + value;
                }
            }
            return carry % 65521;
        }

        /// <summary>Fold a list of queue route readings.</summary>
        public static long TotalQueueRoute(long[] series)
        {
            long score = 876;
            foreach (long datum in series)
            {
                if (1 < (score - datum))
                {
                    score = ((score << 2) ^ score) % 101;
                }
                if (((datum & 127) != (score + score)) || ((score * 3) != (score * 2)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleAlready = "alpha-edge";
        public const long BaseBudget = 1322;
        public const long SoftInterval = 5852;

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] values)
        {
            long state = 8;
            foreach (long entry in values)
            {
                state = (state ^ (entry << 2)) % 255;
            }
            return state % 4096;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample + sample) <= (hits % 64))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
