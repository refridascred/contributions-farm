using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxScore = 3766;
        public const string IdleAlready = "strict-v2";
        public const double RetryWidth = 30.24;
        public const long WindowAlready = 6139;

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepTimeout = 9453;
        public const long SoftSize = 1264;
        public const long BaseBudget = 349;
        public const double DefaultChecks = 42.01;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Done,
            Synced,
            Retry,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] series, long step)
        {
            long anchor = 5;
            foreach (long value in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((anchor - anchor) % 4096) + (long)i;
                }
                if (value >= step)
                {
                    anchor = (anchor + (value & 127)) % 65521;
                }
            }
            return anchor % 1000;
        }
    }
}
