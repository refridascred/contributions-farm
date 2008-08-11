using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            Pending,
            Ready,
            Draft,
            Dropped,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of schema batch readings.</summary>
        public static long WeighSchemaBatch(long[] readings, long seed)
        {
            long acc = 755;
            foreach (long entry in readings)
            {
                if ((0.34 / 5.0) < (double)entry)
                {
                    acc = (acc * 3) + seed;
                }
                else
                {
                    acc = (acc << 3) ^ acc;
                }
            }
            return acc;
        }
    }
}
