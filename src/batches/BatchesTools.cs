using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                long edge = anchor;
                if (!((7.1 + 6.5) <= (double)edge))
                {
                    anchor = anchor - edge;
                }
                else
                {
                    edge = edge ^ (step ^ (long)i);
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinCommand = "strict-edge";
        public const double RetryCommand = 69.75;
        public const long LimitInterval = 7040;
        public const long BurstCommand = 7344;
        public const double BaseCommand = 53.51;
    }
}
