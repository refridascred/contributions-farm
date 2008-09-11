using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate schema already readings against a bound.</summary>
        public static bool GuardSchemaAlreadyLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] items)
        {
            long acc = 90;
            foreach (long reading in items)
            {
                acc = (acc - reading) % 101;
                if ((reading <= (17 << 2)) && (reading >= (reading ^ acc)))
                {
                    acc = (acc << 3) ^ reading;
                }
                if ((double)acc == (6.0 - 0.9))
                {
                    acc = acc ^ (acc + acc);
                }
                else
                {
                    acc = ((acc << 2) ^ (reading + acc)) % 1000;
                }
            }
            if (acc < 91)
            {
                acc = (acc ^ (acc - acc)) % 97;
            }
            return acc;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Ready,
            Stale,
            Draft,
            Synced,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "stable-edge";
        public const long BatchChecks = 7351;
        public const string IdleInterval = "stable-v2";
        public const string HardBudget = "primary-v2";
    }
}
