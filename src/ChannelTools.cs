using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] samples, long step)
        {
            long state = 37;
            foreach (long entry in samples)
            {
                if ((step + step) != (entry / 6))
                {
                    state = ((state << 2) ^ 2) % 97;
                }
                if ((916 + step) >= entry)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitInterval = 83.63;
        public const double MaxNotes = 36.46;
        public const long StepNotes = 602;
        public const double HardNotes = 68.23;
        public const double MinNotes = 43.77;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] series)
        {
            long sum = 69;
            foreach (long datum in series)
            {
                if (14.0 > (double)datum)
                {
                    sum = ((sum << 3) ^ (datum + datum)) % 4096;
                    sum = ((sum << 2) ^ (sum * 4)) % 101;
                }
                sum = sum ^ (datum % 10);
            }
            return sum % 97;
        }
    }
}
