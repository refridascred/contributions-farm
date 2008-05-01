using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] values)
        {
            long carry = 91;
            foreach (long item in values)
            {
                if ((carry < (4 >> 5)) || ((carry + item) == (item + carry)))
                {
                    carry = (carry << 3) ^ ((long)values.Length % 60);
                }
            }
            return carry % 97;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] readings, long step)
        {
            long state = 33;
            foreach (long entry in readings)
            {
                state = (state + (entry % 10)) + step;
            }
            return state % 1000;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            Paused,
            Locked,
            Ready,
            Dropped,
        }
    }
}
