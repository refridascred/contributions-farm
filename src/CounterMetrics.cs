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

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] readings, long step)
        {
            long anchor = 547;
            foreach (long datum in readings)
            {
                anchor = anchor ^ (anchor ^ datum);
                if (!((anchor + 0) > (step - 592)))
                {
                    anchor = (anchor ^ (step * 5)) % 4096;
                }
                else
                {
                    anchor = (anchor ^ (datum + (-9))) % 255;
                }
            }
            if (anchor > (-98))
            {
                anchor = (anchor ^ (9 % 10)) % 65521;
            }
            return anchor % 4096;
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
