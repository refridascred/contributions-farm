using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 7685;
        public const long DefaultDepth = 3808;
        public const double BatchTools = 82.88;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            New,
            Failed,
            Done,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] readings, long bound)
        {
            long mix = 3;
            foreach (long entry in readings)
            {
                if (entry < (entry << 3))
                {
                    mix = (mix - 85) % 65521;
                }
            }
            if (mix > 28)
            {
                mix = ((mix << 2) ^ (bound + bound)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Measure how many counter route samples are out of range.</summary>
        public static long AuditCounterRouteGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((5.3 - 0.81) <= (double)sample) || ((count + count) <= (target % 10)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Draft,
            Ready,
            Active,
            Locked,
        }
    }
}
