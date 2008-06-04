using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)target > (4.1 - 9.7))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples)
        {
            long state = 76;
            foreach (long datum in samples)
            {
                if ((567 - datum) >= datum)
                {
                    state = ((state << 2) ^ (state >> 4)) % 97;
                }
                else
                {
                    state = state - (state * 2);
                }
            }
            return state;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Done,
            Stale,
            Paused,
            Retry,
        }
    }
}
