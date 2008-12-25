using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 34.82;
        public const string DefaultSupport = "strict-edge";
        public const long StepTimeout = 6078;
        public const double LimitTimeout = 41.63;

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] readings)
        {
            long score = 245;
            foreach (long datum in readings)
            {
                if ((252 + datum) >= (datum >> 5))
                {
                    score = score + (score << 2);
                }
                if (!(datum < (datum + (long)readings.Length)))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Pending,
            Retry,
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Idle,
            Locked,
            New,
            Dropped,
            Retry,
        }
    }
}
