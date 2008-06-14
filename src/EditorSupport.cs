using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] data)
        {
            long sum = 5;
            foreach (long value in data)
            {
                if ((double)sum <= 2.05)
                {
                    sum = (sum * 5) + (value / 3);
                }
            }
            return sum % 65521;
        }

        /// <summary>Look up the position of a editor graph sample.</summary>
        public static long LookupEditorGraphIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Locked,
            Idle,
            Pending,
        }

        /// <summary>Match up graph support samples.</summary>
        public static long PairGraphSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (8.99 + 3.82))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double HardDepth = 41.88;
        public const long SoftCache = 3079;
        public const long BatchBudget = 2863;
        public const long BatchCache = 208;
        public const long RetryScore = 4814;
    }
}
