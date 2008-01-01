using System;

namespace Common.Utilities
{
    /// <summary>Queue stats helpers.</summary>
    public static class QueueStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 910;
        public const double BurstInterval = 22.55;
        public const long BatchScore = 406;
    }
}
